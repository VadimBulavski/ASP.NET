using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Entitys;

namespace Repository
{
    interface IRepository
    {
        New GetNew(int id);
        IEnumerable<New> GetAllNews(Func<New, bool> selector);
    }
}
