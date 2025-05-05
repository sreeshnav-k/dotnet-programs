using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormradiolist16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // code writtern inside the not posback on th eload pafe will execute only  once it will not get duplicated on submitting//
            if (!IsPostBack)
            {
                // FOR ADDIND THE OPTION ON RADIO BUTTON VIA CODIND   ,,,,SHOULD BE WRITTEN ON PAGE LOAD//
                Dictionary<string, string> subject = new Dictionary<string, string>

            {
                { "1","science"},
                {"2","maths" },
                { "3","social"}
            };

                foreach (var sub in subject)
                {
                    RadioButtonList2.Items.Add(new ListItem(sub.Value, sub.Key));
                }
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = RadioButtonList1.SelectedItem.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "gender :" + RadioButtonList1.SelectedItem  + "had choosen " + RadioButtonList2.SelectedItem;
        }
    }
}