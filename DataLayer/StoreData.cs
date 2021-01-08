using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

using System.Data.SqlClient;

namespace DataLayer
{
    public class StoreData
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O3OC0O8;Initial Catalog=lab9;Integrated Security=True");

        public string StoreMyData(string name, string username, string password, string address, int age, string gender)
        {
            // string path = @"C:\Users\01-134181-021\desktop\test.txt";
            // FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write );
            //  StreamWriter sw = new StreamWriter(fs);
            //  sw.WriteLine(name);
            //  sw.WriteLine(age);
            //  sw.Close();

          

                con.Open();
                string query = "insert into lab values('" + name + "' , '" + username + "', '" + password + "', '" + address + "', '" + age + "', '" + gender + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();


           

            return "Data Saved Successfully"; ;


        }

        public DataSet RetriveMyData(int a)
        {

            DataSet Ds = new DataSet();
            string q = "select * from lab where Id =" + a + "";
            SqlCommand comm = new SqlCommand(q, con);
            con.Open();
            SqlDataAdapter DA = new SqlDataAdapter(q, con);
            DA.Fill(Ds, " ");
            return Ds;
        }

    }
}
