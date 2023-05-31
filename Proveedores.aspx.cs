using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Proveedores : System.Web.UI.Page
    {
        public ModeloDataContext basededatos = new ModeloDataContext("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\IntentosC#\\FerrelectricosRyF\\App_Data\\BDFerrelectricos.mdf;Integrated Security=True;Connect Timeout=30");
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
        public void cargar()
        {
            datos.DataBind();
        }
        public void limpiar()
        {
            txtnit.Text = "";
            txtempresa.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtcorreo.Text = "";
        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            var misdatos = from registros in basededatos.Proveedores select registros;
            e.Arguments.TotalRowCount = misdatos.Count();
            e.Result = misdatos;
        }

        protected void botonguardar_Click(object sender, EventArgs e)
        {
            try
            {
                int nit = int.Parse(txtnit.Text);
                string empresa = txtempresa.Text;
                string direccion = txtdireccion.Text;
                string telefono = txttelefono.Text;
                string correo = txtcorreo.Text;
                basededatos.insertarProveedores(nit, empresa, direccion, telefono, correo);
                cargar();
                limpiar();


            }
            catch (Exception ex)
            {
                Response.Write("<script> languaje = 'JavaScript'>alert('error en la informacion...!');</script>");
            }

        }

        protected void botonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int nit = int.Parse(txtnit.Text);
                int cuentaregistros = 0;
                var registros = basededatos.buscarProveedores(nit);
                foreach (var campo in registros)
                {
                    txtempresa.Text = campo.Empresa;
                    txtdireccion.Text = campo.Direccion;
                    txttelefono.Text = campo.Telefono;
                    txtcorreo.Text = campo.Correo;
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
                int nit = int.Parse(txtnit.Text);
                string empresa = txtempresa.Text;
                string direccion = txtdireccion.Text;
                string telefono = txttelefono.Text;
                string correo = txtcorreo.Text;
                basededatos.actualizarProveedores(nit, empresa, direccion, telefono, correo);
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
                int nit = int.Parse(txtnit.Text);
                basededatos.eliminarProveedores(nit);
                cargar();
                limpiar();
            }
            catch (Exception ex)
            {
                Response.Write("<script> languaje = 'JavaScript'>alert('error en la informacion...!');</script>");
            }
        }
    }
}