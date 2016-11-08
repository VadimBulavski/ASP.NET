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
            else
            {
                    //ControlCollection collection = Session["control"] as ControlCollection;
                    TestBodyControl.GetCheckedControl(counter, TestBodyControl.FindControl("PlaceHolder1").Controls);
            }
            if (ViewState["count"] == null)
            {
                ViewState["count"] = counter.ToString();
            }
            //ControlCollection collection = Session["control"] as ControlCollection;
        //    if(collection != null)
        //    {
        //        var obj = ViewState["count"];
        //        if(obj != null)
        //        {
        //            counter = Int32.Parse(obj.ToString());
        //            TestBodyControl.GetCheckedControl(counter, collection);
        //        }
        //        else
        //            TestBodyControl.GetCheckedControl(counter, collection);
        //    }
        //    else
        //        Session["control"] = TestBodyControl.FindControl("PlaceHolder1").Controls;
         }

         protected void Page_Init(object sender, EventArgs e)
        {
            ControlCollection collection = Session["control"] as ControlCollection;
            if (collection != null)
            {
                if (IndexHiddenField.Value != null)
                {
                    counter = Int32.Parse(ViewState["count"].ToString());
                }
                TestBodyControl.LoadingDataIntoControl(counter);
                TestBodyControl.GetCheckedControl(counter, collection);
                //var obj = Session["count"];
                //if (obj != null)
                //{
                    
                //}
                //else
                //    TestBodyControl.GetCheckedControl(counter, collection);
            }
            else
                Session["control"] = TestBodyControl.FindControl("PlaceHolder1").Controls;
        }


      
        protected void ButtNext_Click(object sender, EventArgs e)
        {
          
            //TestBodyControl.GetCheckedControl(counter, ;
            //TestBodyControl.GetCheckedControl(counter, control);
            //TestBodyControl.GetCheckedControl(counter, control);
            //Session["control"] = TestBodyControl.FindControl("PlaceHolder1").Controls;
            //object obj = ViewState["count"];
            //if (obj != null)
            //{
            //    counter = Int32.Parse(ViewState["count"].ToString());
            //}
            counter++;
            IndexHiddenField.Value = counter.ToString();

            TestBodyControl.LoadingDataIntoControl(counter);
        }

        protected void ButtPrevious_Click(object sender, EventArgs e)
        {
            //var control = TestBodyControl.FindControl("textAnswer");
            //TestBodyControl.GetCheckedControl(counter, control);
            //Session["control"] = TestBodyControl.Controls;
            //object obj = ViewState["count"];
            //if (obj != null)
            //{
            //    counter = Int32.Parse(ViewState["count"].ToString());
            //}
            counter--;
            //ViewState["count"] = counter.ToString();
            IndexHiddenField.Value = counter.ToString();
            TestBodyControl.LoadingDataIntoControl(counter);
        }
    }
}