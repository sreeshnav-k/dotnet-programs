using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class gridviewex2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection1 dd1 = new dbconnection1();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from details";
            SqlDataReader dr = dd1.getresult(cmd);
            
                GridView1.DataSource = dr;

            GridView1.DataBind();


        }
    }
}