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
        private static ObjectQuestionRepository oqr = new ObjectQuestionRepository();
        private static Test mytes = oqr.GetQuestionAndAnswerData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void LoadingDataIntoControl(int index)
        {
            CreatingFieldForAnswers(index); 
        }

        private void CreatingFieldForAnswers(int index)
        {
            PlaceForAnswer.Controls.Clear();
            nameTest.Text = mytes.Name;
            if (index >= 0 || index <= mytes.Questions.Count)
            {
                bodyQuestion.Text = mytes.Questions[index].QuestionText;
                switch (mytes.Questions[index].Type)
                {
                    case QuestionTypes.Check:
                        foreach (Answer answer in mytes.Questions[index].Answers)
                        {
                           
                            CheckBox cb = new CheckBox();
                            cb.Text = answer.BodyAnswer + "<br />";
                            if (answer.IsChecked)
                            {
                                cb.Checked = true;
                            }
                            PlaceForAnswer.Controls.Add(cb);
                        }
                        break;
                    case QuestionTypes.Radio:
                        foreach (Answer answer in mytes.Questions[index].Answers)
                        {
                            RadioButton rb = new RadioButton();
                            rb.Text = answer.BodyAnswer + "<br />";
                            rb.GroupName = "answer";
                            if (answer.IsChecked)
                            {
                                rb.Checked = true;
                            }
                            PlaceForAnswer.Controls.Add(rb);
                        }
                        break;
                }
            }
        }


        public void GetCheckedControl(int index, ControlCollection controls)
        {
            for (int i = 0; i < controls.Count; ++i)
            {
                if ((controls[i] is CheckBox) && (controls[i] as CheckBox).Checked || (controls[i] is RadioButton)&&(controls[i] as RadioButton).Checked)
                {
                    mytes.Questions[index].Answers[i].IsChecked = true;
                }
            }
        }
    }
}