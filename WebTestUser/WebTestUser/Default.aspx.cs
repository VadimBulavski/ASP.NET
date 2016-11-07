using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTestUser
{
    public partial class Default : System.Web.UI.Page
    {
        public int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TestBodyControl.LoadingDataIntoControl(counter);
            }
            ControlCollection collection = Session["control"] as ControlCollection;
            if(collection != null)
            {
                var obj = ViewState["count"];
                if(obj != null)
                {
                    counter = Int32.Parse(obj.ToString());
                    TestBodyControl.GetCheckedControl(counter, collection);
                    //TestBodyControl.LoadingDataIntoControl(counter);
                }
                else
                    TestBodyControl.GetCheckedControl(counter, collection);
            }
            else
                Session["control"] = TestBodyControl.FindControl("PlaceHolder1").Controls;
        }

      
        protected void ButtNext_Click(object sender, EventArgs e)
        {
          
            //TestBodyControl.GetCheckedControl(counter, ;
            //TestBodyControl.GetCheckedControl(counter, control);
            //TestBodyControl.GetCheckedControl(counter, control);
            Session["control"] = TestBodyControl.FindControl("PlaceHolder1").Controls;
            object obj = ViewState["count"];
            if (obj != null)
            {
                counter = Int32.Parse(ViewState["count"] as string);
            }
            counter++;
            ViewState["count"] = counter.ToString();

            TestBodyControl.LoadingDataIntoControl(counter);
        }

        protected void ButtPrevious_Click(object sender, EventArgs e)
        {
            //var control = TestBodyControl.FindControl("textAnswer");
            //TestBodyControl.GetCheckedControl(counter, control);
            //Session["control"] = TestBodyControl.Controls;
            object obj = ViewState["count"];
            if (obj != null)
            {
                counter = Int32.Parse(ViewState["count"] as string);
            }
            counter--;
            ViewState["count"] = counter.ToString();
            TestBodyControl.LoadingDataIntoControl(counter);
        }
    }
}