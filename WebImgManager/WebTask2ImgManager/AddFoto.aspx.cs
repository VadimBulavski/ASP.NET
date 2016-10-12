using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTask2ImgManager
{
    public partial class AddFoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string saveDir = @"\Images\";
            //string appPath = Request.PhysicalApplicationPath;
            if (FileUploadControl.HasFile)
            {
                string fileName = FileUploadControl.FileName;
                string extension = Path.GetExtension(fileName);
                if ((extension == ".gif") || (extension == ".png") || (extension == ".jpg"))
                {
                    string ralativePath = Path.Combine(saveDir + fileName);
                    string path = Server.MapPath(ralativePath);
                    File.WriteAllBytes(path, FileUploadControl.FileBytes);

                    StatusLabel.Text = "Your file was uploaded successfully.";
                }
                else
                {
                    StatusLabel.Text = "Your file was not uploaded because " +
                                        "it does not have a .gif or .png, or .jpg extension.";
                }
            }
        }

        protected void ButtonViewImages_Click(object sender, EventArgs e)
        {
            Server.Transfer("ViewPhotos.aspx", true);  
        }

    }
}