using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BussinessLayer
{
    class MyLogic
    {
        public string LogicaData(string name, int b)
        {
            StoreData SD = new StoreData();
            return SD.StoremyData(name, b);

        }
        public DataSet RetriveData(int a)
        {
            StoreData SD = new StoreData();
            return SD.RetriveMyData(a);
        }
    }
}
