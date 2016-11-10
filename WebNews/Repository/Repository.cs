using DomainObject.Entitys;
using NewsContext.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository:IRepository
    {

        public DomainObject.Entitys.New GetNew(int id)
        {
            return new New();
        }

        public IEnumerable<DomainObject.Entitys.New> GetAllNews()
        {
            NewsDataContext db = new NewsDataContext();
            return db.News.Select(s => s).ToList();
        }


        public IEnumerable<New> GetNameNews(string name)
        {
            NewsDataContext db = new NewsDataContext();
            return db.News.Where(s=>s.Header.Contains(name)).ToList();
        }
    }
}
