using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebNews.Entitys
{
    public class Comment
    {
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserID { get; set; }
        public int NewID { get; set; }
        public virtual New New { get; set; }
    }
}