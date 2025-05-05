using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlsam.AutoPostBack = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(ddlsam.SelectedItem.Value) == -1)
            {
                Label3.Text = "please select a state";
            }
            else if (int.Parse(ddlsam.SelectedItem.Value) == 1)
            {
                Dictionary<string, string> KERALA = new Dictionary<string, string>
            {
                { "1","kozhikode"},
                { "2","malapuram"},
                { "3","vadakara"}
            };
                foreach (var dis in KERALA)
                {
                    ddlsam2.Items.Add(new ListItem(dis.Value, dis.Key));
                }

            }

            else if (int.Parse(ddlsam.SelectedItem.Value) == 2)
            {
                Dictionary<string, string> tamilnadu = new Dictionary<string, string>
            {
                { "1","chegalpetta"},
                { "2","madurai"},
                { "3","central"}
            };
                foreach (var dis in tamilnadu)
                {
                    ddlsam2.Items.Add(new ListItem(dis.Value, dis.Key));
                }

            }

            else if (int.Parse(ddlsam.SelectedItem.Value) == 2)
            {
                Dictionary<string, string> tamilnadu = new Dictionary<string, string>
            {
                { "1","gangtok"},
                { "2","namchi"},
                { "3","central"}
            };
                foreach (var dis in tamilnadu)
                {
                    ddlsam2.Items.Add(new ListItem(dis.Value, dis.Key));
                }

            }


            else if (int.Parse(ddlsam.SelectedItem.Value) == 3)
            {
                Dictionary<string, string> tamilnadu = new Dictionary<string, string>
            {
                { "1","gangtokfir"},
                { "2","madurai"},
                { "3","central"}
            };
                foreach (var dis in tamilnadu)
                {
                    ddlsam2.Items.Add(new ListItem(dis.Value, dis.Key));
                }

            }
        }
    }
}