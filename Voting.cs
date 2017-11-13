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
    public partial class Voting : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public Voting(string ID)
        {
            InitializeComponent();
            try
            {
                MySqlConnection connectInit = new MySqlConnection(conInfo);
                connectInit.Open();
                String query = "select Nama from society where NoKTP=" + ID;
                MySqlCommand command = new MySqlCommand(query, connectInit);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                lNama.Text = ds.Tables[0].Rows[0]["Nama"].ToString();
                connectInit.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadDatabase();
        }

        private void Voting_Load(object sender, EventArgs e)
        {
            DataSet[] ds = loadDatabase();
            int candidate = Convert.ToInt16(ds[1].Tables[0].Rows[0]["Jumlah"].ToString());
            int rowShould = (candidate / (3 * 2)) + 1; // 3 = column, 2 = ketua dan wakil
            FlowLayoutPanel[] fPanel = new FlowLayoutPanel[candidate];
            Button[] button = new Button[candidate];
            int k = 0; int totalI = 0;
            for (int j = 0; j < rowShould; j++) {
                for (int i = 0; i < 3; i++) {
                    fPanel[totalI] = new FlowLayoutPanel();
                    fPanel[totalI].Size = new Size(295, 95);
                    fPanel[totalI].FlowDirection = FlowDirection.TopDown;
                    button[totalI] = new Button();
                    button[totalI].Size = new Size(fPanel[totalI].Width - 195, fPanel[totalI].Height - 2);
                    //gambar
                    button[totalI].BackgroundImage = Image.FromFile(@"F:\KULIAH\Semester 5\Prak PPK\Project\ProjectPemilu\ProjectPemilu\assets\FIX\"+(totalI+1)+".jpg").GetThumbnailImage(button[totalI].Width, button[totalI].Height, null, IntPtr.Zero);
                    button[totalI].Text = ds[0].Tables[0].Rows[k]["NoUrut"].ToString();
                    button[totalI].TextAlign = ContentAlignment.TopLeft;
                    tableLayoutPanel.Controls.Add(fPanel[totalI], i, tableLayoutPanel.RowCount - 1);
                    fPanel[totalI].Controls.Add(button[totalI]);
                    fPanel[totalI].Controls.Add(new Label { Text = "Nama Kandidat:\nKetua:" + ds[0].Tables[0].Rows[k]["Nama"].ToString() + "\nWakil:" + ds[0].Tables[0].Rows[k + 1]["Nama"].ToString(), AutoSize = true });
                    fPanel[totalI].Controls.Add(new Label { Text = "Quote:\n-" + ds[0].Tables[0].Rows[k]["Quote"].ToString() + "\n-" + ds[0].Tables[0].Rows[k + 1]["Quote"].ToString(), AutoSize = true });
                    button[totalI].Click += new EventHandler(button1_Click);
                    k += 2; totalI++;
                    candidate -= 2;
                    if (candidate == 0) { break; }
                }
                if (j + 1 < rowShould) {
                    tableLayoutPanel.RowCount += 1;
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                }
            }
        }

        private DataSet[] loadDatabase()
        {
            DataSet[] ds = new DataSet[4];
            try
            {
                MySqlConnection connectLoad = new MySqlConnection(conInfo);
                connectLoad.Open();
                string[] query = new string[4];
                query[0] = "select c.NoUrut,c.Jabatan ,s.Nama, c.Quote from candidate c join society s where c.NoKTP=s.NoKTP ORDER BY c.NoUrut ASC, c.Jabatan ASC";
                query[1] = "select COUNT(NoUrut) as Jumlah from candidate";
                query[2] = "select COUNT(NoKTP) as Jumlah from society";
                query[3] = "select COUNT(NoKTP) as Jumlah from society where Voted='true'";
                MySqlCommand command;
                MySqlDataAdapter da;
                for (int i = 0; i < 4; i++)
                {
                    command = new MySqlCommand(query[i], connectLoad);
                    da = new MySqlDataAdapter(command);
                    ds[i] = new DataSet();
                    da.Fill(ds[i]);
                }
                connectLoad.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet[] ds = loadDatabase();
            Button s = (Button)sender;
            try
            {
                MySqlConnection connectEdit = new MySqlConnection(conInfo);
                connectEdit.Open();
                string query = "update society set Voted='true' where Nama='" + lNama.Text + "'";
                MySqlCommand command = new MySqlCommand(query, connectEdit);
                command.ExecuteNonQuery();
                query = "select distinct NoUrut, Percentage from candidate order by NoUrut ASC";
                command = new MySqlCommand(query, connectEdit);
                command.ExecuteNonQuery();
                DataSet temp = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(temp);
                int candidate = Convert.ToInt16(ds[1].Tables[0].Rows[0]["Jumlah"].ToString()) / 2;
                double[] percentage = new double[candidate];
                int[] eachPercentage = new int[2];
                eachPercentage[0] = (Convert.ToInt16(ds[3].Tables[0].Rows[0]["Jumlah"].ToString() + 1) == 0) ?
                    100 : 100 / (Convert.ToInt16(ds[3].Tables[0].Rows[0]["Jumlah"].ToString()) + 1);
                eachPercentage[1] = (Convert.ToInt16(ds[3].Tables[0].Rows[0]["Jumlah"].ToString()) == 0) ?
                    100 : 100 / Convert.ToInt16(ds[3].Tables[0].Rows[0]["Jumlah"].ToString());
                int[] person = new int[candidate];
                for (int i = 0; i < candidate; i++)
                {
                    person[i] = Convert.ToInt16(temp.Tables[0].Rows[i]["Percentage"].ToString()) / eachPercentage[1];
                }
                int allNull = 0;
                for (int i = 0; i < candidate; i++)
                {
                    if (Convert.ToInt32(temp.Tables[0].Rows[i]["Percentage"].ToString()) != 0)
                    {
                        allNull = 1;
                    }
                }
                for (int i = 0; i < candidate; i++)
                {
                    int now;
                    if (allNull == 1)
                    {
                        now = (s.Text == temp.Tables[0].Rows[i]["NoUrut"].ToString()) ?
                            eachPercentage[0] * (person[i] + 1) : eachPercentage[0] * person[i];
                    }
                    else
                    {
                        now = (s.Text == temp.Tables[0].Rows[i]["NoUrut"].ToString()) ?
                            eachPercentage[0] : 0;
                    }
                    query = "update candidate set Percentage=" + now + " where NoUrut=" + (i + 1);
                    command = new MySqlCommand(query, connectEdit);
                    command.ExecuteNonQuery();
                }
                TempResult tempResult = new TempResult();
                tempResult.Show();
                this.Hide();
                connectEdit.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
