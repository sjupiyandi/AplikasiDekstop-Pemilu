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
    public partial class LoginCustomer : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public LoginCustomer()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNoKTP.Text != "")
            {
                try
                {
                    MySqlConnection connectLogin = new MySqlConnection(conInfo);
                    connectLogin.Open();
                    String query = "select * from society where NoKTP=" + tbNoKTP.Text;
                    MySqlCommand command = new MySqlCommand(query, connectLogin);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(dt);
                    da.Fill(ds);
                    if (dt.Rows.Count == 1)
                    {
                        if (ds.Tables[0].Rows[0]["Voted"].ToString() == "false")
                        {
                            Voting voting = new Voting(tbNoKTP.Text);
                            this.Hide();
                            voting.Show();
                            MessageBox.Show("Selamat datang!!!", "WELCOME");
                        }
                        else
                        {
                            MessageBox.Show("Nomor KTP ini sudah pernah melakukan voting", "WARNING");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No KTP Salah", "WARNING");
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
                MessageBox.Show("Isi No KTP");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            this.Hide();
            loginAdmin.Show();
        }

    }
}
