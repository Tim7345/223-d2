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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source= 35.232.253.102;" + "Initial Catalog=D2;" + "User ID=sqlserver;" + "Password=Kiwitim247");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = usernameTextBox.Text;
                string pass = passwordTextBox.Text;
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM manager where username='" + usernameTextBox.Text + "' AND password='" + passwordTextBox.Text + "'";
                dr = cmd.ExecuteReader();
                Form1 loginScreen = new Form1();
                Form2 mainScreen = new Form2();
                if (dr.Read())
                {
                    MessageBox.Show("Login success");
                    mainScreen.Show();
                    loginScreen.Close();
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    

                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
