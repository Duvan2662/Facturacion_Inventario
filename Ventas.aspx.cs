using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Ventas : System.Web.UI.Page
    {
        public SqlCommand comando;
        public SqlConnection conexion = new SqlConnection(
       "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\IntentosC#\\mejorar 3\\BDFerrelectricos.mdf\";Integrated Security=True;Connect Timeout=30");
        public static double ventaTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }
        }

        protected void clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.Text = clientes.SelectedValue;
            String consulta = "SELECT * FROM Clientes WHERE ID=" + txtid.Text;
            comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtdireccion.Text = (leer.GetString(2));
                txttelefono.Text = (leer.GetString(3));
                txtcorreo.Text = (leer.GetString(4));
            }
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

        protected void comboproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var codigoproducto = comboproducto.SelectedValue;
            string consulta = "SELECT * FROM Productos WHERE ID=" + codigoproducto;
            comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtvalorunitario.Text = leer.GetSqlDecimal(3).ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int existenciaActual = 0;

            // Obtener la cantidad deseada ingresada por el vendedor
            int cantidadDeseada = int.Parse(txtcantidad.Text);

            // Obtener el ID del producto seleccionado
            string productoID = comboproducto.SelectedValue.ToString();


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


            if (existenciaActual >= cantidadDeseada)
            {
                if (Session["dt"] == null)
                {
                    DataTable dt = rellenartabla();
                    DataRow fila;
                    fila = dt.NewRow();
                    fila["ID"] = comboproducto.SelectedValue.ToString();
                    fila["Producto"] = comboproducto.SelectedItem;
                    fila["Valor unitario"] = txtvalorunitario.Text;
                    fila["Cantidad"] = txtcantidad.Text;
                    fila["Valor Total"] = int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text);
                    ventaTotal = ventaTotal + (int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text));
                    dt.Rows.Add(fila);
                    detalleproducto.DataSource = dt;
                    detalleproducto.DataBind();
                    Session["dt"] = dt;
                }
                else
                {
                    DataTable dt = (DataTable)(Session["dt"]);
                    DataRow fila;
                    fila = dt.NewRow();
                    fila["ID"] = comboproducto.SelectedValue.ToString();
                    fila["Producto"] = comboproducto.SelectedItem;
                    fila["Valor unitario"] = txtvalorunitario.Text;
                    fila["Cantidad"] = txtcantidad.Text;
                    fila["Valor Total"] = int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text);
                    ventaTotal = ventaTotal + (int.Parse(txtcantidad.Text) * int.Parse(txtvalorunitario.Text));
                    dt.Rows.Add(fila);
                    detalleproducto.DataSource = dt;
                    detalleproducto.DataBind();
                    Session["dt"] = dt;
                }

                txtventatotal.Text = ventaTotal.ToString();

                int nuevaExistencia = existenciaActual - cantidadDeseada;
                ActualizarExistenciaEnBD(productoID, nuevaExistencia);
            }
            else
            {
                string mensaje = $"No hay suficiente stock disponible. Stock actual: {existenciaActual}";
                string script = $"<script>alert('{mensaje}');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "ErrorStockScript", script);
                txtcantidad.Text = "";
            }


            
        }
        private void ActualizarExistenciaEnBD(string productoID, int nuevaExistencia)
        {
            string consulta = "UPDATE Productos SET Existencia = @NuevaExistencia WHERE ID = @ProductoID";
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@NuevaExistencia", nuevaExistencia);
            comando.Parameters.AddWithValue("@ProductoID", productoID);
            comando.ExecuteNonQuery();
        }


        protected void btnguardar_Click(object sender, EventArgs e)
        {
            String consulta = "INSERT into Ventas values(@ID, @Fecha, @IDCliente, @IDProducto, @Cantidad, @ValorUnitario, @Total)";
            comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = consulta; // Asignar la consulta al comando
                conexion.Open();
                foreach (GridViewRow fila in detalleproducto.Rows)
                {
                    SqlCommand insertarv = new SqlCommand(consulta, conexion);
                    insertarv.Parameters.Clear();
                    insertarv.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(txtnumerofactura.Text);
                    insertarv.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = DateTime.Parse(txtfechaventa.Text); // Convertir a DateTime
                    insertarv.Parameters.Add("@IDCliente", SqlDbType.Int).Value = int.Parse(txtid.Text);
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
        private void limpiar()
        {
            txtnumerofactura.Text = "";
            txtid.Text = "";
            txtcorreo.Text = "";
            txtvalorunitario.Text = "";
            txtdireccion.Text = "";
            txtcantidad.Text = "";
            txttelefono.Text = "";
            txtventatotal.Text = "";
            detalleproducto.DataSource = null;
            detalleproducto.DataBind();
            ventaTotal = 0;
            Session.Abandon();
        } 
        
    }
}