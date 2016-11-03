using DomainObject.Entitys;
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

        public IEnumerable<DomainObject.Entitys.New> GetAllNews(Func<DomainObject.Entitys.New, bool> selector)
        {
            return Enumerable.Empty<New>();
        }
    }
}
