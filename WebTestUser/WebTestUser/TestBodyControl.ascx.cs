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
            //if(textAnswer.Controls.Count == 0)
            //{
                
            //}
            //else
            //{
            //    foreach(Control control in textAnswer.Controls){
            //        if ((control as CheckBox).Checked || (control as RadioButton).Checked)
            //        {
            //            Test mytes = GetTest();
            //            foreach (Answer answer in mytes.Questions[index].Answers)
            //            {
            //                answer.IsChecked = true;
            //            }
            //        }
            //    }
            //    textAnswer.Controls.Clear();
            //    CreatingFieldForAnswers(index);
            //}
        }

        private void CreatingFieldForAnswers(int index)
        {
            PlaceHolder1.Controls.Clear();
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
                            PlaceHolder1.Controls.Add(cb);
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
                            PlaceHolder1.Controls.Add(rb);
                        }
                        break;
                }
            }
        }


        public void GetCheckedControl(int index, ControlCollection controls)
        {
            foreach (Control contr in controls)
            {
                if ((contr is CheckBox) && (contr as CheckBox).Checked || (contr is RadioButton)&&(contr as RadioButton).Checked)
                {
                    foreach (Answer answer in mytes.Questions[index].Answers)
                    {
                        answer.IsChecked = true;
                    }
                }
            }
        }
    }
}