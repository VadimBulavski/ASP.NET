using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DomainObject.Entitys
{
    class User
    {
        [Key]
        public int UserID { get; set; }
    }
}
