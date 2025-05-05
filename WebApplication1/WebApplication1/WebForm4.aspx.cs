using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=int.Parse(TextBox1.Text);
            int num2=int.Parse(TextBox2.Text);
            int sum = num1 + num2;
            Label3.Text = sum.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
   
            int sub = num1 - num2;
            Label3.Text = sub.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int mul = num1 * num2;
            Label3.Text = mul.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int div = num1 / num2;
            Label3.Text = div.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label3.Text = "";
        }
    }
}