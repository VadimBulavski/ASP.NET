using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAsyncResponce.App_Code
{
    interface IRepository
    {
        IEnumerable<Product> GetProductCollection(); 
    }
}
