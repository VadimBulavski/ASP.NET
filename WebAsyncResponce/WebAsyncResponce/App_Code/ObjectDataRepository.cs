using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAsyncResponce.App_Code
{
    public class ObjectDataRepository:IRepository
    {


        public List<Product> Products = new List<Product>()
            {
                new Product(){Name = "Product 1", Category = "Category 1"},
                new Product(){Name = "Product 2", Category = "Category 2"},
                new Product(){Name = "Product 3", Category = "Category 1"},
                new Product(){Name = "Product 4", Category = "Category 1"},
                new Product(){Name = "Product 5", Category = "Category 2"},
                new Product(){Name = "Product 6", Category = "Category 2"},
            };
        public IEnumerable<Product> GetProductCollection()
        {
            //Products 
            return Products;
        }
    }
}