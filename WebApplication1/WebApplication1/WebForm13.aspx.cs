using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> employee = new Dictionary<string,string>
            {
                { "123","appu"},
                { "224","kiran"},
                { "333","ammu"}
            };

            foreach (var emp in employee)
            {
                ddlemp.Items.Add(new ListItem(emp.Value, emp.Key));
            }
        }

        protected void ddlemp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(ddlemp.SelectedItem.Value)==-1)
            {
                Label2.Text = "please select an option";
            }

            else
            {
                Label2.Text = "selected employee_name " + ddlemp.SelectedItem.Text + "<br> his emplyee code is :" + ddlemp.SelectedValue;
            }
        }
    }
}