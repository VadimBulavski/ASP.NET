using DomainObject.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsContext.Context
{
    public class NewsDataContext:DbContext
    {
        public NewsDataContext() : base("NewsContext") { }

        public DbSet<New> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
