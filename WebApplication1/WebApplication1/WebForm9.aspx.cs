using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double hight=int.Parse(TextBox1.Text);
            double weight=int.Parse(TextBox2.Text);
            double hightm = hight / 100;
            double bmi = (weight / (hightm*hightm));
            TextBox3.Text=bmi.ToString();
        }
    }
}