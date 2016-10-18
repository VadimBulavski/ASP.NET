using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTestUser
{
    public enum QuestionTypes { Check, Radio }

    public class Question
    {
        
        public string QuestionText { get; set; }
        public QuestionTypes Type { get; set; }
        public List<Answer> Answers { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> CorrectAnswerList { get; set; }

        public Question() { }
        public Question(QuestionTypes type, string correctAnswer)
        {
            Type = type;
            CorrectAnswer = correctAnswer;
        }

        public Question(QuestionTypes type, List<string> correctAnswerList)
        {
            Type = type;
            CorrectAnswerList = new List<string>();
        }
    }
}
