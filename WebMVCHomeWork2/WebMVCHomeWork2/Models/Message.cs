using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCHomeWork2.Models
{
    public class Message
    {
        public Guid IdUser 
        {
            get
            {
                return Guid.NewGuid();
            }  
        }

        public DateTime TimeMessage { get; set; }
        public string MessageText { get; set; }
    }
}