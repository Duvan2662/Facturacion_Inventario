using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Graficos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ventaId = txtid.Text;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\IntentosC#\\FerrelectricosRYF\\App_Data\\BDFerrelectricos.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Filtrar los datos y realizar la unión entre las tablas Ventas y Productos
                string queryString = @"SELECT v.Cantidad, p.Nombre
                               FROM Ventas v
                               JOIN Productos p ON v.IDProducto = p.ID
                               WHERE v.ID = @VentaId";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@VentaId", ventaId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);

                    // Actualizar el gráfico
                    Chart1.DataSource = filteredTable;
                    Chart1.Series[0].XValueMember = "Nombre"; // Utilizar el nombre del producto para los valores X
                    Chart1.Series[0].YValueMembers = "Cantidad";
                    Chart1.DataBind();
                }
            }
            //SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\IntentosC#\\FerrelectricosRYF\\App_Data\\BDFerrelectricos.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}