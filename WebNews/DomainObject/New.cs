using DomainObject.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNews.Entitys
{
    public class New
    {
        [Key]
        public int NewsID { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Hot { get; set; }
        public TypeNews TypeNews { get; set; }
        

        public virtual List<Comment> Comments { get; set; }
    }
}