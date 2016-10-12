using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTask2ImgManager
{
    public partial class ViewPhotos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> files = Directory.GetFiles(Server.MapPath("Images")).ToList();
                
                foreach (string pathFile in files)
                {
                    Image img = new Image();
                    img.Height = 300;
                    img.Width = 300;
                    string fileName = pathFile.Substring(pathFile.LastIndexOf('\\')+1);
                    img.ImageUrl = @"Images/" + fileName;
                    imgView.Controls.Add(img);
                }
            }
        }
    }
}