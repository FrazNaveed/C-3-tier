using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;


namespace BusinessLayers
{
    class MyLogic
    {
        public string LogicalData(string name, string username, string password, string address, int age, string gender)
        {
            StoreData SD = new StoreData();
           return SD.StoreMyData(name, username, password, address, age, gender);
        }

        public DataSet RetriveData(int a)
        {
            StoreData SD = new StoreData();
            return SD.RetriveMyData(a);
        }
    }
}
