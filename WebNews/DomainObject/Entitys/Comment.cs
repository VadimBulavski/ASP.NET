using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObject.Entitys
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }


        public virtual User User { get; set; }
        public virtual New NewID { get; set; }
    }
}
