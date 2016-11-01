using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T>:IRepository<T>
    {
        public IEnumerable<T> GetAllNews()
        {
            using(var db = new NewsContext)
        }
    }
}
