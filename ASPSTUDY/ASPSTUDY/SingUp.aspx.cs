using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPSTUDY
{
    public partial class SingUp : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["AspDb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "insert into singnup values(@fname,@lname,@gender,@email,@address,@username,@password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@fname",FirstNameTextBox.Text);
            cmd.Parameters.AddWithValue("@lname", LastNameTextBox.Text);
            cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
            cmd.Parameters.AddWithValue("@address", AddressTextBox.Text);
            cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
            conn.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0) 
            {
                ClientScript.RegisterStartupScript(typeof(Page),"script","alert('SignUp SuccessFully..  Username is "+UserNameTextBox.Text+" and  Password is : "+PasswordTextBox.Text+"')",true);
                ClearControlls();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<scripts>alert('SignUp Failed')</scripts>");
            }
            conn.Close();


        }
        void ClearControlls()
        {
            FirstNameTextBox.Text = LastNameTextBox.Text = EmailTextBox.Text = AddressTextBox.Text = PasswordTextBox.Text = ConfirmPasswordTextBox.Text = "";
            DropDownList1.ClearSelection(); 
        }
    }
}