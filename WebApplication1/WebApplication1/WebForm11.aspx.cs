using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=int.Parse(TextBox1.Text);
            int num2 = 10;
            for (int i = 1; i < num2; i++)
            {

                Label2.Text += i + "*" + num1 + "=" + i * num1 + "<br>";
            }
        }
    }
}