using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectPemilu
{
    public partial class LoginAdmin : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginCustomer loginCustomer = new LoginCustomer();
            this.Hide();
            loginCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    MySqlConnection connectLogin = new MySqlConnection(conInfo);
                    connectLogin.Open();
                    String query = "select * from administrator where NoID=" + textBox1.Text + " && Password=" + textBox2.Text;
                    MySqlCommand command = new MySqlCommand(query, connectLogin);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Administrator administrator = new Administrator(textBox1.Text);
                        this.Hide();
                        administrator.Show();
                        MessageBox.Show("Selamat datang!!!", "WELCOME");
                    }
                    else
                    {
                        MessageBox.Show("ID Admin atau Password Salah", "WARNING");
                    }
                    connectLogin.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Isi ID Admin dan Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabKey(object sender, KeyEventArgs e)
        {

        }
    }
}
