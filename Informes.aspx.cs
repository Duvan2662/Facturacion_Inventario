using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FerrelectricosRYF
{
    public partial class Informes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\IntentosC#\\mejorar 3\\BDFerrelectricos.mdf\";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ventas WHERE IDCliente ='" + txtid.Text + "'",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1",dt);
            ReportViewer1.LocalReport.DataSources.Add(rp);
            ReportViewer1.LocalReport.Refresh();
           
        }

        protected void todos_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\IntentosC#\\mejorar 3\\BDFerrelectricos.mdf\";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ventas", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rp);
            ReportViewer1.LocalReport.Refresh();
        }
    }
}