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
    public partial class FormSociety : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public FormSociety() //menambah
        {
            InitializeComponent();
            lTitle.Text = "Form Penambahan Society";
            bSave.Visible = false;
            tbNoKTP.ReadOnly = false;
        }

        public FormSociety(string[] prev)
        {
            InitializeComponent();
            button1.Visible = false;
            tbNoKTP.Text = prev[0];
            tbNama.Text = prev[1];
            tbAlamat.Text = prev[2];
            if (prev[3] == "WNI") {
                rbWNI.Checked = true;
            } else if (prev[3] == "WNA") {
                rbWNA.Checked = true;
            }
        }


        private void bSave_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection connectEdit = new MySqlConnection(conInfo);
                connectEdit.Open();
                string check = "WNI";
                if (rbWNI.Checked) {
                    check = "WNI";
                }
                else if (rbWNA.Checked)  {
                    check = "WNA";
                }
                string query = "update society set Nama='" + tbNama.Text + "', Alamat='" + tbAlamat.Text + "', Kependudukan='" + check + "' where NoKTP=" + tbNoKTP.Text;
                MySqlCommand command = new MySqlCommand(query, connectEdit);
                command.ExecuteNonQuery();
                MessageBox.Show("Finish");
                connectEdit.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectAdd = new MySqlConnection(conInfo);
                connectAdd.Open();
                string check = "WNI";
                if (rbWNI.Checked)
                {
                    check = "WNI";
                }
                else if (rbWNA.Checked)
                {
                    check = "WNA";
                }
                string query = "insert into society values ('" + tbNoKTP.Text + "','" + tbNama.Text + "','" + tbAlamat.Text + "','" + check + "','false')";
                MySqlCommand command = new MySqlCommand(query, connectAdd);
                command.ExecuteNonQuery();
                MessageBox.Show("Finish");
                connectAdd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }
    }
}
