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
    public partial class Administrator : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public Administrator(string ID)
        {
            InitializeComponent();
            try {
                MySqlConnection connectInit = new MySqlConnection(conInfo);
                connectInit.Open();
                String query = "select s.Nama from administrator a join society s where a.NoID=" + ID + " AND a.NoKTP=s.NoKTP";
                MySqlCommand command = new MySqlCommand(query, connectInit);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                lHi.Text += ds.Tables[0].Rows[0]["Nama"].ToString();
                connectInit.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            loadDatabase();
        }

        private void loadDatabase()
        {
            try
            {
                MySqlConnection connectLoad = new MySqlConnection(conInfo);
                connectLoad.Open();
                string[] query = new string[3];
                query[0] = "select c.NoUrut,c.Jabatan,c.Percentage,s.NoKTP,s.Nama,c.Quote from candidate c join society s where c.NoKTP=s.NoKTP ORDER BY c.NoUrut ASC, c.Jabatan ASC";
                query[1] = "select * from society";
                query[2] = "select distinct NoUrut, Percentage from candidate ORDER BY NoUrut ASC";
                MySqlCommand command;
                MySqlDataAdapter da;
                DataSet[] ds = new DataSet[3];
                for (int i = 0; i < 3; i++)
                {
                    command = new MySqlCommand(query[i], connectLoad);
                    da = new MySqlDataAdapter(command);
                    ds[i] = new DataSet();
                    da.Fill(ds[i]);
                }
                dataGridCandidate.DataSource = ds[0].Tables[0].DefaultView;
                dataGridSociety.DataSource = ds[1].Tables[0].DefaultView;
                dataGridResult.DataSource = ds[2].Tables[0].DefaultView;
                connectLoad.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            this.Hide();
            loginAdmin.Show();
            MessageBox.Show("Berhasil Logout!!!");
        }

        private void dataGridCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            operationDataGrid(sender, e, 0);
        }

        private void dataGridSociety_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            operationDataGrid(sender, e, 1);
        }

        private void operationDataGrid(object sender, DataGridViewCellEventArgs e, int which)
        {
            var senderGrid = (DataGridView)sender;
            DataGridViewColumn column = senderGrid.Columns[e.ColumnIndex];
            DataGridViewRow row = senderGrid.Rows[e.RowIndex];
            String table = (which == 0) ? "candidate" : "society";
            if (column is DataGridViewButtonColumn && e.RowIndex >= 0) {
                if (column.HeaderText == "Edit") {
                    string[] value = new string[4];
                    if (table == "candidate") {
                        value[0] = row.Cells["NoKTP"].Value.ToString();
                        value[1] = row.Cells["NoUrut"].Value.ToString();
                        value[2] = row.Cells["Jabatan"].Value.ToString();
                        value[3] = row.Cells["Quote"].Value.ToString();
                        FormCandidate formCandidate = new FormCandidate(value);
                        formCandidate.Show();
                    } else if (table == "society") {
                        value[0] = row.Cells["NoKTP"].Value.ToString();
                        value[1] = row.Cells["Nama"].Value.ToString();
                        value[2] = row.Cells["Alamat"].Value.ToString();
                        value[3] = row.Cells["Kependudukan"].Value.ToString();
                        FormSociety formSociety = new FormSociety(value);
                        formSociety.Show();
                    }
                }
                else if (column.HeaderText == "Remove") {
                    string nama = row.Cells["Nama"].Value.ToString();
                    string noKTP = row.Cells["NoKTP"].Value.ToString();
                    DialogResult result = MessageBox.Show("Really remove "+ nama + "?", "WARNING", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection connectDelete = new MySqlConnection(conInfo);
                            connectDelete.Open();
                            string query = "delete from " + table + " where NoKTP=" + noKTP;
                            MySqlCommand command = new MySqlCommand(query, connectDelete);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Finish");
                            connectDelete.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        loadDatabase();
                    }
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FormCandidate formCandidate = new FormCandidate();
            formCandidate.Show();
        }

        private void Administrator_Activated(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectEdit = new MySqlConnection(conInfo);
                connectEdit.Open();
                string[] query = new string[2];
                query[0] = "update candidate set Percentage = 0";
                query[1] = "update society set Voted = 'false'";
                MySqlCommand command;
                for (int i = 0; i < 2; i++)
                {
                    command = new MySqlCommand(query[i], connectEdit);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Changed Done:\nVoted = false\nPercentage = 0", "OPERATION COMPLETE");
                connectEdit.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSociety formSociety = new FormSociety();
            formSociety.Show();
        }

        

        
    }
}
