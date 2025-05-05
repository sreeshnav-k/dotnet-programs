using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm22excalender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        /* {
             Label1.Text = Calendar1.SelectedDate + "<br/>";
             string dattim=Calendar1.SelectedDate.ToString();
             string[]arr= dattim.Split(' ');

             Label1.Text = "selected date" + arr[0] + "<br/>";
             Label1.Text = "selected time" + arr[1] + "<br/>";



         } */
        {
            // Get the selected date from the calendar
            DateTime selectedDate = Calendar1.SelectedDate;

            // Display the selected date
            Label1.Text = "Selected date: " + selectedDate.ToShortDateString() + "<br/>";

            // Since the Calendar control does not provide a time, we can display a default time or the current time
            DateTime currentTime = DateTime.Now; // You can also set a specific time if needed
            Label1.Text += "Current time: " + currentTime.ToShortTimeString() + "<br/>";
        }
    }
}