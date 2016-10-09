using MyWeekDayServerControl;
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
                    ServerControl1 sc = new ServerControl1();
                    if (day == DateTime.Now.DayOfWeek.ToString())
                    {
                        sc.ForeColor = Color.Red;
                        sc.Font.Underline = true;
                    }
                    sc.Text = day + "<br /><br />";
                    sc.Font.Size = 16;
                    sc.Font.Bold = true;
                    UserContent.Controls.Add(sc);
                }
            }
        } 
    }
}