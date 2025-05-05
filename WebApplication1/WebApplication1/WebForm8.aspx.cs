using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            double num1=int.Parse(TextBox2.Text);
            double num2 = int.Parse(TextBox3.Text); // int.parse is used to change the string into int(textbox will accepy the value in string//
            double num3 = int.Parse(TextBox4.Text);
            double num4 = int.Parse(TextBox5.Text);//all the num should be in double then only percentage will be in double//
            double total=num1 + num2 + num3 + num4;
            double percentage = (total * 100) / 400;
            string grade;
            if (percentage > 90) {
                grade = "A";
            }
            else if(total >= 80){
                grade = "B";
            }
            else if (total >= 70)
            {
                grade = "C";
            }
            else if(total >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }
                Label6.Text = "name: " + name +"<br>"+" total marks: " + total +"<br>"+ "percentage: " + percentage + "<br>"+" grade: " + grade;
        }
    }
}