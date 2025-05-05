using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class progressreport3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
          
            
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double intotals = Convert.ToInt16(Session["intotal"].ToString());
            double extotal=int.Parse(TextBox1.Text);
            double total = extotal + intotals;
            Session["total"]=total;
           

                Response.Redirect("progressreport4.aspx");

                
        }
    }
}