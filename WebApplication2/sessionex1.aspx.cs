using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class sessionex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["uname"]=TextBox1.Text;  //creating a session
            Session["pword"]=TextBox2.Text;
            Response.Redirect("sessionex2.aspx");//redirecting to next page
        }
    }
}