using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10PANEL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int reminder, sum = 0;
            int temp = num1;

            while (num1 > 0)
            {
                reminder = num1 % 10;
                sum = sum + reminder * reminder * reminder;
                num1 = num1 / 10;

            }
            if (sum == temp)
            {
                Label2.Text = "the given no is amstrong";

            }
            else
            {
                Label2.Text = "the given no is not amstrong";
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            /*   int num1= int.Parse(TextBox2.Text);
             int num2= int.Parse(TextBox3.Text);
             int reminder, sum = 0;
             int temp = num1;
             for (int i = num1; i < num2; i++)
             {
                 while (i > 0)
                 {
                     reminder = i % 10;
                     sum = sum + reminder * reminder * reminder;
                     i = i / 10;

                 }
             }
                 if (sum == num1)
                 {
                     Label5.Text += num1.ToString()+ "<br>";
                 }


         */
            int lower = int.Parse(TextBox2.Text);
            int upper = int.Parse(TextBox3.Text);
            int reminder;

            for (int i = lower; i <= upper; i++)
            {
                int temp = i;
                int sum = 0;
                int digits = i.ToString().Length;
                while (temp > 0)
                {
                    reminder= temp % 10;
                    sum = sum + (int)Math.Pow( reminder, digits);
                    temp /= 10;
           
                }
                if (sum== i)
                    Label5.Text = i.ToString() + "<br>";
            }


        } }
    }