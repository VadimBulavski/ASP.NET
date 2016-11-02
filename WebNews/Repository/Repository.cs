using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Entitys;

namespace Repository
{
    public class Repository:IRepository
    {

        public IEnumerable<WebNews.Entitys.New> GetAllNews(Func<WebNews.Entitys.New, bool> selector)
        {
            return Enumerable.Empty<New>();
        }

        public New GetNew(int id)
        {
            return new New();
        }
    }
}
