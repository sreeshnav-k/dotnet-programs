using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class datalistex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
          
        }
        protected void button1_command(object sender,CommandEventArgs e)
        {
            if(e.CommandName == "remove")
                {
                int idToRemove=Convert.ToInt32(e.CommandArgument);  
                dbconnection1 db =new dbconnection1();
                SqlCommand cmd = new SqlCommand("delete from student where id =@id");
                cmd.Parameters.AddWithValue("id", idToRemove);
                db.execute(cmd);
                BindData();

            }
        }
        private void BindData()
        {
            dbconnection1 db = new dbconnection1();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from STUDENT";
            SqlDataReader dr = db.getresult(cmd);
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }


    }

}