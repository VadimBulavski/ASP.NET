using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebValidationExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/scripts/jquery-3.1.1.min.js",

            });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid) {
                double dividend = Double.Parse(TextBox1.Text);
                double divider = Double.Parse(TextBox2.Text);
                Label1.Text = String.Format("{0}", dividend / divider);
            }
        }
    }
}