﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class sessionex11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double mark1=int.Parse(TextBox2.Text);
            double mark2 = int.Parse(TextBox3.Text);
            double mark3 = int.Parse(TextBox4.Text);
            double mark4 = int.Parse(TextBox5.Text);

            double sum=mark1 + mark2+mark3 + mark4;
            double avg = sum / 4;

            Session["name"]=TextBox1.Text;
            Session["total"]=sum;
            Session["average"]=avg;

            Response.Redirect("sessionex22.aspx");
        }
    }
}