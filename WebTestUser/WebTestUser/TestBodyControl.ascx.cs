using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTestUser
{
    public partial class TestBodyControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoadingDataIntoControl(int index)
        {

            ObjectQuestionRepository oqr = new ObjectQuestionRepository();
            Test mytes = oqr.GetQuestionAndAnswerData();
            nameTest.Text = mytes.Name;
            bodyQuestion.Text = mytes.Questions[index].
            foreach(Question quest in mytes.Questions)
            {
                
            }
        }
    }
}