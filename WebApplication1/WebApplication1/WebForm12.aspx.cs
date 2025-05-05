using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num=int.Parse(TextBox1.Text);
            int sum = 0;
            int rev;
             while(num > 0)
            {
                rev = num % 10;           ////123
                sum=(sum*10)+rev;   //3
                num /= 10;
            }
             TextBox2.Text = sum.ToString();
            

        }
    }
}