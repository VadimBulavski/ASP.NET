﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObject.Entitys
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
    }
}
