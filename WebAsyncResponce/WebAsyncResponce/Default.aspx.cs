using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAsyncResponce
{
    public partial class Default : System.Web.UI.Page
    {
        App_Code.ObjectDataRepository odsp = new App_Code.ObjectDataRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                UpdateDataSource(); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            odsp.Products.Add(new App_Code.Product() { Name = TextBox1.Text, Category = TextBox2.Text});
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            Thread.Sleep(3000);
            GridView1.DataSource = odsp.GetProductCollection();
            GridView1.DataBind();
        }
    }
}