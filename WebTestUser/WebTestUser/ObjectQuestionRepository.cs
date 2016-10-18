using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTestUser
{
    public class ObjectQuestionRepository : IRepository
    {
        public Test GetQuestionAndAnswerData()
        {
            Test firsTest = new Test("First Test", new TimeSpan(0, 15, 0));
            Question question1 = new Question(QuestionTypes.Check, new List<string>() { "answer1", "answer3" })
            {
                QuestionText = "Question 1",
                Answers = new List<Answer>()
                {
                  new Answer("answer1"),
                  new Answer("answer2"),
                  new Answer("answer3"),
                  new Answer("answer4"),
                  new Answer("answer5")
                }
            };

            Question question2 = new Question(QuestionTypes.Check, new List<string>() { "answer2", "answer4" })
            {
                QuestionText = "Question 2",
                Answers = new List<Answer>()
                {
                  new Answer("answer1"),
                  new Answer("answer2"),
                  new Answer("answer3"),
                  new Answer("answer4"),
                  new Answer("answer5")
                }
            };

            Question question3 = new Question(QuestionTypes.Radio, "answer2")
            {
                QuestionText = "Question 3",
                Answers = new List<Answer>()
                {
                  new Answer("answer1"),
                  new Answer("answer2"),
                  new Answer("answer3"),
                  new Answer("answer4"),
                  new Answer("answer5")
                }
            };

            Question question4 = new Question(QuestionTypes.Radio, "answer4")
            {
                QuestionText = "Question 4",
                Answers = new List<Answer>()
                {
                  new Answer("answer1"),
                  new Answer("answer2"),
                  new Answer("answer3"),
                  new Answer("answer4"),
                  new Answer("answer5")
                }
            };

            Question question5 = new Question(QuestionTypes.Check, new List<string>() { "answer1", "answer5" })
            {
                QuestionText = "Question 5",
                Answers = new List<Answer>()
                {
                  new Answer("answer1"),
                  new Answer("answer2"),
                  new Answer("answer3"),
                  new Answer("answer4"),
                  new Answer("answer5")
                }
            };

            firsTest.Questions.Add(question1);
            firsTest.Questions.Add(question2);
            firsTest.Questions.Add(question3);
            firsTest.Questions.Add(question4);
            firsTest.Questions.Add(question5);

            return firsTest;
        }
    }
}