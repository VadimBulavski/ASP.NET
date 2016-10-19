using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTestUser
{
    public class Answer
    {
        public string BodyAnswer { get; set; }
        public Answer() { }
        public Answer(string textAnswer)
        {
            BodyAnswer = textAnswer;
        }
    }
}
