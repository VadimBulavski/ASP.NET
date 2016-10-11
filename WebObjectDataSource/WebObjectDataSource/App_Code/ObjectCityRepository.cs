using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebObjectDataSource.App_Code
{
    public class ObjectCityRepository:IRepository
    {
        public IEnumerable<City> GetCityCollection()
        {
            List<City> citys = new List<City>(){
                new City(){ NameCity="Minsk", Area = 348.84, Population = 1959781 },
                new City(){ NameCity="Brest", Area = 117, Population = 340141 },
                new City(){ NameCity="Mogilev", Area = 118.5, Population = 378007 },
                new City(){ NameCity="Gomel", Area = 135.34, Population = 521452 },
                new City(){ NameCity="Vitebsk", Area = 124.54, Population = 376226},
                new City(){ NameCity="Grodno", Area = 142.11, Population = 365610 }
            };
            return citys;
        }
    }
}