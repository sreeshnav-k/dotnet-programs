using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm33 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["n1"];
            string password = Request.QueryString["n2"];

            Label2.Text = "welcome"+name+"<br>your password is "+password;
        }
    }
}