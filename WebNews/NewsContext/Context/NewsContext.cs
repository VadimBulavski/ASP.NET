using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebNews.Entitys;

namespace WebNews.Context
{
    public class NewsContext:DbContext
    {
        public DbSet<New> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}