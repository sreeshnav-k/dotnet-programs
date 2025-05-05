using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm20 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text=="")
            {
                Label8.Text = "enter name ";
            }
            else
            {
                Label8.Text = "";  // for removing the error msg
            }
            if(DropDownList1.SelectedItem.Value=="-1")
            {
                Label9.Text = "select qualification";
            }
            else
            {
                Label9.Text = "";

            }
            if(!RadioButton1.Checked && !RadioButton2.Checked && !RadioButton3.Checked)
            {
                Label10.Text = "select gender";
            }
            else
            {
                Label10.Text = "";
            }
            if(!CheckBox1.Checked)
            {
                Label7.Text = "confirm your data";

            }
            else
            {
                Label7.Text = "";
            }
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            DropDownList1.ClearSelection();
            Label7.Text= string.Empty;
            Label8.Text = string.Empty;
            Label9.Text = string.Empty;
            Label10.Text = string.Empty;
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            TextBox2.Text = string.Empty;
            DropDownList2.ClearSelection();
            CheckBox1.Checked = false;

        }
    }
}