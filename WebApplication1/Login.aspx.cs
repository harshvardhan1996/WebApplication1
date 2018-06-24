using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        public object Checkbox1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(TextBox2.Text, TextBox3.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox2.Text, false);
            }
            else
            {
                Label1.Text = "Invalid User Name and Password";
            }
        }
    }
}