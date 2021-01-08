using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayers;
using System.Data.SqlClient;

namespace ApplicationLayer
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O3OC0O8;Initial Catalog=appDB;Integrated Security=True");

        public void populate()
        {
            con.Open();
            string query = "select * from appTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        public Form1()
        {
            InitializeComponent();
           // populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string name = textBox1.Text;

                string username = textBox4.Text;
                string password = textBox5.Text;
                if (textBox6.Text == textBox5.Text)
                {
                    label8.Text = "Matched";
                }
                string address = textBox7.Text;
                int age = Convert.ToInt32(textBox2.Text);
                string gender = Convert.ToString(comboBox1.SelectedItem);

                Facade fc = Facade.GetController();
                fc.MyData(name, username, password, address, age, gender);
                // populate();
            }
            catch (Exception ex)
            {
                label9.Text = ex.GetType() + ": " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facade Fc = Facade.GetController();
            DataSet ds = Fc.RetrivePass(int.Parse(textBox3.Text));
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
