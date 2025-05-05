using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormRADIO15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

            // RADIO BUTTON SHOULD BE GROUPED UNDER SAME GROUPNAME INORDER TO SELECT ANY ON OPTION
        {
            if (rbtmale.Checked)
                Label2.Text = rbtmale.Text;
            else if (rbtfemale.Checked)
                Label2.Text = "you have slected "+ rbtfemale.Text;
            else if (rbtothers.Checked)
                Label2.Text = rbtothers.Text;
            else
                Label2.Text = "please select any gender";

        }
    }
}