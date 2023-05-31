using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Compras : System.Web.UI.Page
    {
        public SqlCommand comando;
        public SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\IntentosC#\\mejorar 3\\BDFerrelectricos.mdf\";Integrated Security=True;Connect Timeout=30");
        public static double ventaTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int existenciaActual = 0;

            // Obtener la cantidad deseada ingresada por el vendedor
            int cantidadInsertada = int.Parse(txtcantidad.Text);

            // Obtener el ID del producto seleccionado
            string productoID = producto.SelectedValue.ToString();


            //consulta
            string consulta = "SELECT Existencia FROM Productos WHERE ID = @ProductoID";
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@ProductoID", productoID);
            conexion.Open();
            var result = comando.ExecuteScalar();
            if (result != null)
            {
                existenciaActual = Convert.ToInt32(result);
            }



            if (Session["dt"] == null)
            {
                DataTable dt = rellenartabla();
                DataRow fila;
                fila = dt.NewRow();
                fila["ID"] = producto.SelectedValue.ToString();
                fila["Producto"] = producto.SelectedItem;
                fila["Valor unitario"] = txtvalorunitario.Text;
                fila["Cantidad"] = txtcantidad.Text;
                fila["Valor Total"] = int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text);
                ventaTotal = ventaTotal + (int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text));
                dt.Rows.Add(fila);
                detalleCompra.DataSource = dt;
                detalleCompra.DataBind();
                Session["dt"] = dt;
            }
            else
            {
                DataTable dt = (DataTable)(Session["dt"]);
                DataRow fila;
                fila = dt.NewRow();
                fila["ID"] = producto.SelectedValue.ToString();
                fila["Producto"] = producto.SelectedItem;
                fila["Valor unitario"] = txtvalorunitario.Text;
                fila["Cantidad"] = txtcantidad.Text;
                fila["Valor Total"] = int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text);
                ventaTotal = ventaTotal + (int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text));
                dt.Rows.Add(fila);
                detalleCompra.DataSource = dt;
                detalleCompra.DataBind();
                Session["dt"] = dt;
            }

            txtventatotal.Text = ventaTotal.ToString();
            int nuevaExistencia = existenciaActual + cantidadInsertada;
            ActualizarExistenciaEnBD(productoID, nuevaExistencia);

        }
        private void ActualizarExistenciaEnBD(string productoID, int nuevaExistencia)
        {
            string consulta = "UPDATE Productos SET Existencia = @NuevaExistencia WHERE ID = @ProductoID";
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@NuevaExistencia", nuevaExistencia);
            comando.Parameters.AddWithValue("@ProductoID", productoID);
            comando.ExecuteNonQuery();
        }

        protected void proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnit.Text = proveedor.SelectedValue;
            CargarProductos(int.Parse(txtnit.Text));
        }

        private void CargarProductos(int idProveedor)
        {
            string consulta = "SELECT ID, Nombre FROM Productos WHERE IDProveedor = @IDProveedor";
                using (comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IDProveedor", idProveedor);
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    producto.DataSource = reader;
                    producto.DataTextField = "Nombre";
                    producto.DataValueField = "ID";
                    producto.DataBind();
                    reader.Close();
                }

            conexion.Close();
        }

        public DataTable rellenartabla()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", Type.GetType("System.String"));
            dt.Columns.Add("Producto", Type.GetType("System.String"));
            dt.Columns.Add("Valor unitario", Type.GetType("System.String"));
            dt.Columns.Add("Cantidad", Type.GetType("System.String"));
            dt.Columns.Add("Valor Total", Type.GetType("System.String"));
            return dt;
        }
       

        private void limpiar()
        {
            txtnumerocompra.Text = "";
            txtnit.Text = "";
            txtvalorunitario.Text = "";
            txtcantidad.Text = "";
            txtventatotal.Text = "";
            detalleCompra.DataSource = null;
            detalleCompra.DataBind();
            ventaTotal = 0;
            Session.Abandon();
        }

        protected void btnguardar_Click1(object sender, EventArgs e)
        {
            String consulta = "INSERT into Compras values(@ID, @Fecha, @NitProveedor, @IDProducto, @Cantidad, @ValorUnitario, @Total)";
            comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = consulta; // Asignar la consulta al comando
                conexion.Open();
                foreach (GridViewRow fila in detalleCompra.Rows)
                {
                    SqlCommand insertarv = new SqlCommand(consulta, conexion);
                    insertarv.Parameters.Clear();
                    insertarv.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtnumerocompra.Text);
                    insertarv.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = DateTime.Parse(txtfechacompra.Text); // Convertir a DateTime
                    insertarv.Parameters.Add("@NitProveedor", SqlDbType.Int).Value = int.Parse(txtnit.Text);
                    insertarv.Parameters.Add("@IDProducto", SqlDbType.Int).Value = int.Parse(fila.Cells[0].Text);
                    insertarv.Parameters.Add("@Cantidad", SqlDbType.Int).Value = int.Parse(fila.Cells[3].Text);
                    insertarv.Parameters.Add("@ValorUnitario", SqlDbType.Int).Value = int.Parse(fila.Cells[2].Text);
                    insertarv.Parameters.Add("@Total", SqlDbType.Int).Value = int.Parse(fila.Cells[4].Text);
                    insertarv.ExecuteNonQuery();
                }
                Response.Write("<script language='JavaScript'>alert('Registroguardado...!!!');</script>");
                limpiar();
            }
            catch (SqlException ex) { }
            catch (Exception ex) { }
            finally
            {
                conexion.Close();
            }
        }
    }
}