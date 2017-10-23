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
    public partial class FormCandidate : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public FormCandidate() //menambah
        {
            InitializeComponent();
            lTitle.Text = "Form Penambahan Candidate";
            bSave.Visible = false;
            tbNoKTP.ReadOnly = false;
        }

        public FormCandidate(string[] prev) //mengedit
        {
            InitializeComponent();
            bAdd.Visible = false;
            tbNoKTP.Text = prev[0];
            tbNoUrut.Text = prev[1];
            if (prev[2] == "Ketua") {
                rbKetua.Checked = true;
            } else if (prev[2] == "Wakil") {
                rbWakil.Checked = true;
            }
            tbQuote.Text = prev[3];
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection connectEdit = new MySqlConnection(conInfo);
                connectEdit.Open();
                string check = "Ketua";
                if (rbKetua.Checked) {
                    check = "Ketua";
                } else if (rbWakil.Checked) {
                    check = "Wakil";
                }
                string query = "update candidate set NoUrut=" + Convert.ToInt16(tbNoUrut.Text) + ", jabatan='" + check + "', Quote='" + tbQuote.Text + "' where NoKTP=" + tbNoKTP.Text;
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

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection connectAdd = new MySqlConnection(conInfo);
                connectAdd.Open();
                string check = "Ketua";
                if (rbKetua.Checked) {
                    check = "Ketua";
                } else if (rbWakil.Checked) {
                    check = "Wakil";
                }
                string query = "insert into candidate values ('" + tbNoKTP.Text + "','" + tbNoUrut.Text + "','" + check + "','" + tbQuote.Text + "',0)";
                MySqlCommand command = new MySqlCommand(query, connectAdd);
                command.ExecuteNonQuery();
                MessageBox.Show("Finish");
                connectAdd.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }
    }
}
