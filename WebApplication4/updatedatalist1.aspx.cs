using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class updatedatalist1 : System.Web.UI.Page
    {
        string a = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                a = Request.QueryString["id"];

                dbconnection1 db = new dbconnection1();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from STUDENT WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", a);
                SqlDataReader dr = db.getresult(cmd);

                if(dr.Read())
                {
                    TextBox1.Text=dr.GetInt32(0).ToString();
                    TextBox2.Text = dr.GetString(1);
                    TextBox3.Text = dr.GetInt32(2).ToString();
                    TextBox4.Text = dr.GetString(3);

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dbconnection1 db =new dbconnection1();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update STUDENT set name=@name,age=@age where id=@id";
            cmd.Parameters.AddWithValue("@Id",TextBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@AGE", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
            db.execute(cmd);
            Response.Redirect("datalistex1.aspx");
        }
    }
}