using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BussinessLayer
{
    public class Facade
    {
        private Facade() { }
        public static Facade instance = null;
        public static Facade GetController()
        {
            if (instance == null)
            {
                instance = new Facade();
            }
            return instance;
        }

        public string MyData(string name, int b)
        {
            MyLogic Ml = new MyLogic();
            return Ml.LogicaData(name, b);
        }

        public DataSet RetrivePass(int a)
        {
            MyLogic Ml = new MyLogic();
           return Ml.RetriveData(a);
        }
    }
}
