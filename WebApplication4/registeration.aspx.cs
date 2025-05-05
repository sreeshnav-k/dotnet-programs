using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(DropDownList1.SelectedItem.Value) == 1)
            {
                Panel3.Visible=true;
                Panel2.Visible=false;
            }
            else
            {
                Panel2.Visible=true;
                Panel3.Visible=false;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dbconnection1 db1 = new dbconnection1();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into datasheet values(@employee code_value,@name_value,@password_value,@designation_value,@department_value,@subjects_value";
            cmd.Parameters.AddWithValue("@employee code_value", TextBox3.Text);
            cmd.Parameters.AddWithValue("@name_value", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password_value", TextBox1.Text);
            cmd.Parameters.AddWithValue("@designation", (DropDownList1.SelectedItem.Text));
            string dept = "";
            if(DropDownList1.SelectedValue=="1")
            {
                dept=DropDownList1.SelectedItem.Text;
            }
            cmd.Parameters.AddWithValue("@department_value",dept);
            string sub = "";
            if(DropDownList1.SelectedValue=="2")
            {
                foreach(ListItem li in CheckBoxList1.Items)
                {
                    if(li.Selected)
                    {
                        sub = sub + li.Text + ",";
                    }
                }
                cmd.Parameters.AddWithValue("@subjects_value",sub);
                db1.execute(cmd);
            }



        }
    }
}