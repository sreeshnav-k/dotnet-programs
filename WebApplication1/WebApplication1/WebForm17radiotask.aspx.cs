using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm17radiotask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BUTTON1_Click(object sender, EventArgs e)
        {
            RadioButtonList1.ClearSelection();
            RadioButtonList2.ClearSelection();
            RadioButtonList3.ClearSelection();
            RadioButtonList4.ClearSelection();
            RadioButtonList5.ClearSelection();
            Label7.Text = " ";



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            if (int.Parse(RadioButtonList1.SelectedItem.Value) == 1)
            {
                sum+=2;
            }
            else 
                {
                sum--;

            }
            if (int.Parse(RadioButtonList2.SelectedItem.Value) == 2)
            {
                sum += 2;
            }
            else 
            {
                sum--;

            }
            if (int.Parse(RadioButtonList3.SelectedItem.Value) == 3)
            {
                sum += 2;
            }
            else
            {
                sum--;

            }
            if (int.Parse(RadioButtonList4.SelectedItem.Value) == 1)
            {
                sum += 2;
            }
            else 
            {
                sum--;

            }
            if (int.Parse(RadioButtonList5.SelectedItem.Value) == 2)
            {
                sum += 2;
            }

            else 
            {
                sum--;

            }

            Label7.Text = "total marks obtained is" + sum;

        }
    }
    } 