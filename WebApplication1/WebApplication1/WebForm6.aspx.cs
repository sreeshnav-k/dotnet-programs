using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(TextBox1.Text);
            if (age > 18)
            {
                Label1.Text = "major";
            }
            else
            {
                Label1.Text = "minor";
            }
        }
    }
}
