using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomainObject.Entitys;
using System.ComponentModel.DataAnnotations;

namespace WebNews.Entitys
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }


        public virtual User UserId{ get; set; }
        public virtual New NewID { get; set; }

    }
}