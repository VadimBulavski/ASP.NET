using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTestUser
{
    public class Answer
    {
        public string BodyAnswer { get; set; }
        public bool IsChecked { get; set; }
        public Answer() { IsChecked = false; }
        public Answer(string textAnswer)
        {
            BodyAnswer = textAnswer;
            IsChecked = false;
        }
    }
}
