using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPSTUDY
{
    public partial class CustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack) 
            {
                Response.Write("This is post back!");
            }

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
                int a = int.Parse(args.Value);
            if (a % 2 == 0) 
            {
                args.IsValid= true;
            }
            else
            {
                args.IsValid= false;
            }
        }
    }
}