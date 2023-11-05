﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPSTUDY
{
    public partial class VALIDATIONFORM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Your Form has Been Submited.')</script>");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(MaleRadioButton.Checked || FemaleRadioButton.Checked) 
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