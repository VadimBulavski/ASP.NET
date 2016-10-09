using Days;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerControl
{
    public partial class WebFormWeekDays : System.Web.UI.Page
    {
        List<string> days = new List<string>() {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string day in days)
                {
                    this.ServerControl.Text += day;
                    //ListItem item = new ListItem(ServerControl.Text);
                    //this.ListBox1.Items.Add(item);
                }
            }
        } 
    }
}