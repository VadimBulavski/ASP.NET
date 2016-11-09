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
            if (!IsPostBack)
            {
                TestBodyControl.LoadingDataIntoControl(counter);
            }
            else
            {
                if (IndexHiddenField.Value == string.Empty)
                {
                    IndexHiddenField.Value = counter.ToString();
                }
                TestBodyControl.GetCheckedControl(Int32.Parse(IndexHiddenField.Value),
                                                  TestBodyControl.FindControl("PlaceForAnswer").Controls);
            }
            
         }

        protected void Page_Init(object sender, EventArgs e)
        {
            var obj = Session["control"] as TestBodyControl;
            if (obj != null)
            {
                TestBodyControl.FindControl("PlaceForAnswer").Controls = 
                    Session["control"] as ControlCollection;
            }
            Session["control"] = TestBodyControl.FindControl("PlaceForAnswer").Controls;
        }


      
        protected void ButtNext_Click(object sender, EventArgs e)
        {
          
            if (IndexHiddenField.Value != null)
            {
                counter = Int32.Parse(IndexHiddenField.Value);
            }
            counter++;
            IndexHiddenField.Value = counter.ToString();
            TestBodyControl.LoadingDataIntoControl(counter);
        }

        protected void ButtPrevious_Click(object sender, EventArgs e)
        {
            if (IndexHiddenField.Value != null)
            {
                counter = Int32.Parse(IndexHiddenField.Value);
            }
            counter--;
            IndexHiddenField.Value = counter.ToString();
            TestBodyControl.LoadingDataIntoControl(counter);
        }
    }
}