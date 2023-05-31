using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Verificar las credenciales del usuario
            bool credencialesValidas = VerificarCredenciales(nombreUsuario, contraseña);

            if (credencialesValidas)
            {
                // Iniciar sesión exitosamente
                //Response.Redirect("Plantilla.Master?parametro=" + nombreUsuario);
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                // Mostrar mensaje de error
                lblMensajeError.Text = "Credenciales inválidas. Por favor, inténtalo nuevamente.";
                txtContraseña.Text = "";
                txtNombreUsuario.Text = "";
                txtNombreUsuario.Focus();
            }
        }
        private bool VerificarCredenciales(string nombreUsuario, string contraseña)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\IntentosC#\\mejorar 2\\BDFerrelectricos.mdf\";Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    return count > 0;
                }
            }
        }
        
    }

}