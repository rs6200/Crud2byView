using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPSTUDY
{
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["AspDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string querry = "select * from singnup where username = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@user", UserNameTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["user"] = UserNameTextBox.Text;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<scripts>alert('Login Successfully')</scripts>");
                Response.Redirect("About.aspx");

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<scripts>alert('Login Failed')</scripts>");

            }
            con.Close();

        }
    }
}