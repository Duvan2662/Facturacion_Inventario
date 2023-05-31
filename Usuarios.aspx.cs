using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Usuarios : System.Web.UI.Page
    {
        public ModeloDataContext basededatos = new ModeloDataContext("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\IntentosC#\\FerrelectricosRYF\\BDFerrelectricos.mdf;Integrated Security=True;Connect Timeout=30");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                botoneliminar.Attributes.Add("Onclick", "return confirm('Desea eliminar el registro.... ?')");
                botonguardar.Attributes.Add("Onclick", "return alert('Registro guardado...')");
                botonmodificar.Attributes.Add("Onclick", "return alert('Registro modificado...')");
                cargar();
            }
        }

        protected void botonguardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                string nombre = txtnombre.Text;
                string contrasena = txtcontasena.Text;
                string cargo = txtcargo.Text;
                basededatos.insertarUsuarios(id, nombre, contrasena, cargo);
                cargar();
                limpiar();
            }
            catch (Exception ex)
            {
                Response.Write("<script> languaje = 'JavaScript'>alert('error en la informacion...!');</script>");
            }
        }
        public void cargar()
        {
            datos.DataBind();
        }
        public void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtcontasena.Text = "";
            txtcargo.Text = "";
        }

        protected void botonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                int cuentaregistros = 0;
                var registros = basededatos.buscarUsuarios(id);
                foreach (var campo in registros)
                {
                    txtnombre.Text = campo.Nombre;
                    txtcontasena.Text = campo.Contraseña;
                    txtcargo.Text = campo.Cargo;
                    cuentaregistros = 1;
                }
                if (cuentaregistros == 0)
                {
                    Response.Write("<script>alert('Nit no existe....!!!');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> languaje = 'JavaScript'>alert('error en la informacion...!');</script>");
            }

        }

        protected void botonmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                string nombre = txtnombre.Text;
                string contrasena = txtcontasena.Text;
                string cargo = txtcargo.Text;
                basededatos.actualizarUsuarios(id, nombre, contrasena, cargo);
                cargar();
                limpiar();

            }
            catch (Exception ex)
            {
                Response.Write("<script> languaje = 'JavaScript'>alert('error en la informacion...!');</script>");
            }
        }

        protected void botoneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                basededatos.eliminarUsuarios(id);
                cargar();
                limpiar();
            }
            catch (Exception ex)
            {
                Response.Write("<script> languaje = 'JavaScript'>alert('error en la informacion...!');</script>");
            }
        }
        protected void LinqDataSource1_Selecting1(object sender, LinqDataSourceSelectEventArgs e)
        {
            var misdatos = from registros in basededatos.Usuarios select registros;
            e.Arguments.TotalRowCount = misdatos.Count();
            e.Result = misdatos;
        }
    }
}