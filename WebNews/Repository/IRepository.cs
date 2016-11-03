using DomainObject.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        New GetNew(int id);
        IEnumerable<New> GetAllNews();
    }
}
