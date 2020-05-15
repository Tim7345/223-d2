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

namespace COMPX223_D2
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Form1 loginScreen = new Form1();
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source= 35.232.253.102;" + "Initial Catalog=D2;" + "User ID=sqlserver;" + "Password=Kiwitim247");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd2DataSet.customer' table. You can move, or remove it, as needed.
           // this.customerTableAdapter.Fill(this.d2DataSet.customer);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM customer";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable customerData = new DataTable();
            da.Fill(customerData);
            this.customerTableAdapter.Fill(this.d2DataSet.customer);
            //dataGridView1.DataSource = new BindingSource(customerData, null);
            con.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM customer";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable customerData = new DataTable();
            da.Fill(customerData);
            con.Close();
           // dataGridView1.DataSource = new BindingSource(customerData, null);
           */
        }
    }
}
