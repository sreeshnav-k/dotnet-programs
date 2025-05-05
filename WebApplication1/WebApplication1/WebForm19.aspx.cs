using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)      //USED TO AVOID REPEATION
            {
                Dictionary<string, string> sam = new Dictionary<string, string>
            {
                {"1","clt" },
                {"2","mlp" },
                {"3","idk" }
            };
                foreach (var i in sam)
                    CheckBoxList1.Items.Add(new ListItem(i.Value, i.Key));        //1 st element that is i.value gets printed
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = " ";
            if (CheckBox1.Checked)
            { 
            Label1.Text += CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                Label1.Text += CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {
                Label1.Text+= CheckBox3.Text.ToString();
            }
            // we are con


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ListItem item in CheckBoxList1.Items) 
            {
                if (item.Selected)
                {
                   list.Add(item.Value+"--------"+item.Text);
                }
            }
            /*
            Label2.Text = string.Join("<br>", list);
            */

            Response.Write(string.Join(" ", list));    //alternate option
        }
    }
}