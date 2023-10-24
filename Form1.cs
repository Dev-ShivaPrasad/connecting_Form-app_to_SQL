using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_DB_Connect
{
    public partial class Form1 : Form
    {   
        //global declaration
        string connection_string = "Data Source=SHIVA-DSK\\SQLEXPRESS;Initial Catalog=db1;Integrated Security=True";//change the sting before executing
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {   
            //1. address of SQL server and database
            //2. establish connection
            SqlConnection conn = new SqlConnection(connection_string);
            //3. open connection
            conn.Open();
            //4. prepare query
            string fname = Fname.Text;
            string mname = Mname.Text;
            string lname = Lname.Text;
            int age = Convert.ToInt32(Age.Text);
            string work = Work.Text;
            string query = "insert into table1 values('"+fname+"','"+mname+"','"+lname+"',"+age+",'"+work+"');";
            //5. execute query
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //6. close connection
            conn.Close();
            MessageBox.Show("Data saved Successfully");
        }

        private void Display_Click(object sender, EventArgs e)
        {   
            //1. address of SQL server and database
            
            //2. establish connection
            SqlConnection conn = new SqlConnection(connection_string);
            //3. open connection
            conn.Open();
            //4. prepare query
            string query = "select *from table1";
            //5. execute query
            SqlCommand cmd = new SqlCommand(query, conn);
            var read = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(read);  

            dataGridView1.DataSource = dt;
            //6. close connection
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
