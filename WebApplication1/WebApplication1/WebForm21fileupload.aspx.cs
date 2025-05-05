using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm21fileupload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // we have to create a folder>>add>>newfolder//
            if(FileUpload1.HasFile)
            {
                string filename = FileUpload1.FileName;
                string filepath=Server.MapPath("~/FILEUPLOADER/"+filename);
                FileUpload1.SaveAs(filepath);
                Label1.Text = "file uploaded successfully";



            }
            else
            {
                Label1.Text = "please select file";
            }
        }
    }
}