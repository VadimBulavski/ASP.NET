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

        public void LoadingDataIntoControl(int index)
        {
            textAnawer.Controls.Clear();
            ObjectQuestionRepository oqr = new ObjectQuestionRepository();
            Test mytes = oqr.GetQuestionAndAnswerData();
            nameTest.Text = mytes.Name;
            if(index >= 0 || index <= mytes.Questions.Count)
            {
                bodyQuestion.Text = mytes.Questions[index].QuestionText;
                switch (mytes.Questions[index].Type)
                {
                    case QuestionTypes.Check:
                        foreach (Answer answer in mytes.Questions[index].Answers)
                        {
                            CheckBox cb = new CheckBox();
                            cb.Text = answer.BodyAnswer + "<br />";
                            textAnawer.Controls.Add(cb);
                        }
                        break;
                    case QuestionTypes.Radio:
                        foreach (Answer answer in mytes.Questions[index].Answers)
                        {
                            RadioButton rb = new RadioButton();
                            rb.Text = answer.BodyAnswer + "<br />";
                            rb.GroupName = "answer";
                            textAnawer.Controls.Add(rb);
                        }
                        break;
                }
            } 
        }
    }
}