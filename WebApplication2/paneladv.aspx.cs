using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class paneladv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opt=DropDownList1.SelectedValue;
            if( opt=="1")
            {
                TextBox1.Text = "1000";
            }
            else if (opt == "2")
            {
                TextBox1.Text = "2000";
            }
            else if (opt == "3")
            {
                TextBox1.Text = "3000";
            }
            else
                TextBox1.Text = "select an product";



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double qty = int.Parse(TextBox2.Text);
            double cost=int.Parse(TextBox1.Text);
            double total = qty * cost;
            TextBox3.Text=total.ToString();
        }
    }
}