using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebXmlService
{
    interface IRepository
    {
        IEnumerable<Rate> GetDataRate();
        IEnumerable<Currency> GetDataCurrency();
    }
}
