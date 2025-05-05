using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm26placeholder : System.Web.UI.Page
    {
        public Label newlabel1 = new Label();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // create a new label control
            newlabel1.Text = "this is dynamically added label";

            //add the label to the placeholder
            PlaceHolder1.Controls.Add(newlabel1);
        }
    }
}