using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ado2Practice
{
    public partial class AdoWebform2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"data source=ASUSNARENDRA;initial catalog=Sample1;intergrated security=true";
                con.Open();

                lblMessage.Text = "Connected Successfully to SQL Server";
                con.Close();
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}