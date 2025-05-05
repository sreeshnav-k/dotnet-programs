using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int mark = int.Parse(TextBox2.Text);
            string name= TextBox1.Text;
            if (mark > 40)
            {
                Label3.Text = "congratulation"+name+ "has passed";
                Label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label3.Text = "sorry "+ name+" you have failed";
                Label3.ForeColor = System.Drawing.Color.DarkRed;
            }
        }
    }
}