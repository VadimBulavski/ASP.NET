using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Entitys;

namespace Repository
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAllNews();
    }
}
