using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLayers
{
   public class Facade
    {
        private Facade() { }

        public static Facade instance = null;  //object of facade

        public static Facade GetController()   // function having return type facade
        {
            if(instance == null)
            { 
                instance = new Facade();   // instance is the connection bw presentation and business layer 

            }
            return instance;
        }

        public string MyData(string name , string username, string password, string address, int age, string gender)
        {
            MyLogic ML = new MyLogic();
            return ML.LogicalData(name ,username, password, address, age, gender);
            
        }

        public DataSet RetrivePass(int a)
        {
            MyLogic Ml = new MyLogic();
            return Ml.RetriveData(a);
        }

    }
}
