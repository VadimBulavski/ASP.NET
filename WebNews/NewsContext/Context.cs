using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DomainObject;
using WebNews.Entitys;

namespace WebNews.Context
{
    public class NewsContext:DbContext
    {
        NewsContext() : base("NewsContext") { }

        public DbSet<New> News { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}