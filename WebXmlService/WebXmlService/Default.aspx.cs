using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebXmlService
{
    public partial class Default : System.Web.UI.Page
    {
        XmlServiseRepository xsr = new XmlServiseRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = xsr.GetDataRate();
                GridView1.DataBind();
                GridView2.DataSource = xsr.GetDataCurrency();
                GridView2.DataBind();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            GridView1.DataSource = xsr.GetDataRate();
            GridView1.DataBind();
            GridView2.DataSource = xsr.GetDataCurrency();
            GridView2.DataBind();
        }
    }
}