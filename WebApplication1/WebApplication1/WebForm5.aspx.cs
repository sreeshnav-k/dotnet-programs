using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=int.Parse(TextBox3.Text);
           int  num2 = int.Parse(TextBox4.Text);
          int  num3 = int.Parse(TextBox5.Text);
          int  num4 = int.Parse(TextBox6.Text);
            int total=num1 + num2+num3 + num4;
            int avg = (total / 4);
            Label8.Text=total.ToString();
            Label9.Text=avg.ToString();
            Label10.Text = "sum is" + total + "\n average is " + avg;
        }
    }
}