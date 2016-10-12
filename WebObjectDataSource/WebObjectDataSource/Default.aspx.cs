using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebObjectDataSource
{
    public partial class Default : System.Web.UI.Page
    {
  
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    App_Code.ObjectCityRepository abcr = new App_Code.ObjectCityRepository();
            //    ListBox1.DataSource = abcr.GetCityCollection();
            //    ListBox1.DataTextField = "NameCity";
            //    ListBox1.DataBind();
            //}

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            
            App_Code.XMLObjectCityRepository xmlCreator = new App_Code.XMLObjectCityRepository();
            xmlCreator.CreateXMLDocument(Server.MapPath("/"));
        }
    }
}