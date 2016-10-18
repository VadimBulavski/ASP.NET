using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTestUser
{
    public class Test
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        public TimeSpan TimeToRespond { get; set; }

        public Test() 
        {
            Questions = new List<Question>(); 
        }
        public Test(string name, TimeSpan time)
        {
            Name = name;
            TimeToRespond = time;
            Questions = new List<Question>();
        }
    }
}