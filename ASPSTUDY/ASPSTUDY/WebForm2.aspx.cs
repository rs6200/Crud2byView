using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASPSTUDY
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["AspDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = Getdata();
            GridView1.DataSource = dt;
            GridView1.DataBind(); 

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        DataTable Getdata()
        {
            SqlConnection conn = new SqlConnection(cs);
            string querry = "select * from Emp";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            return data;
        }

     
    }
}