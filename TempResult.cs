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
    public partial class TempResult : Form
    {
        static string conInfo = "datasource='localhost'; username='root'; password=''; database='pemilu';";

        public TempResult()
        {
            InitializeComponent();
            DataSet[] ds = loadDatabase();
            int candidate = Convert.ToInt16(ds[1].Tables[0].Rows[0]["Jumlah"].ToString()) / 2;
            int voted = Convert.ToInt16(ds[2].Tables[0].Rows[0]["Jumlah"].ToString());

            int rowShould = candidate / 3 + 1; // 3 = column
            FlowLayoutPanel[] fPanel = new FlowLayoutPanel[candidate];
            Button[] button = new Button[candidate];
            int totalI = 0;
            for (int j = 0; j < rowShould; j++) {
                for (int i = 0; i < 3; i++) {
                    fPanel[totalI] = new FlowLayoutPanel();
                    fPanel[totalI].Size = new Size(295, 95);
                    fPanel[totalI].FlowDirection = FlowDirection.TopDown;
                    button[totalI] = new Button();
                    button[totalI].Size = new Size(fPanel[totalI].Width - 195, fPanel[totalI].Height - 2);
                    //gambar
                    button[totalI].BackgroundImage = Image.FromFile(@"F:\KULIAH\Semester 5\Prak PPK\Project\ProjectPemilu\ProjectPemilu\assets\FIX\" + (totalI + 1) + ".jpg").GetThumbnailImage(button[totalI].Width, button[totalI].Height, null, IntPtr.Zero);
                    button[totalI].Text = ds[0].Tables[0].Rows[totalI]["NoUrut"].ToString();
                    button[totalI].TextAlign = ContentAlignment.TopLeft;
                    button[totalI].Enabled = false;
                    tableLayoutPanel.Controls.Add(fPanel[totalI], i, tableLayoutPanel.RowCount - 1);
                    fPanel[totalI].Controls.Add(button[totalI]);
                    fPanel[totalI].Controls.Add(new Label { Text = "Nomor Urut:" + ds[0].Tables[0].Rows[totalI]["NoUrut"].ToString(), AutoSize = true });
                    fPanel[totalI].Controls.Add(new Label { Text = "Percentage:" + ds[0].Tables[0].Rows[totalI]["Percentage"].ToString() + " %", AutoSize = true });
                    totalI++;
                    candidate--;
                    if (candidate == 0) { break; }
                }
                if (j + 1 < rowShould)
                {
                    tableLayoutPanel.RowCount += 1;
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                }
            }
        }

        private DataSet[] loadDatabase()
        {
            DataSet[] ds = new DataSet[3];
            try
            {
                MySqlConnection connectLoad = new MySqlConnection(conInfo);
                connectLoad.Open();
                string[] query = new string[3];
                query[0] = "select distinct NoUrut, Percentage from candidate ORDER BY NoUrut ASC";
                query[1] = "select COUNT(NoUrut) as Jumlah from candidate";
                query[2] = "select COUNT(NoKTP) as Jumlah from society WHERE Voted = 'true'";
                MySqlCommand command;
                MySqlDataAdapter da;
                for (int i = 0; i < 3; i++)
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

        int timeLeft = 20;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0) {
                timeLeft -= 1;
                labelTimer.Text = "Time Left: " + timeLeft + " second(s)";
            } else {
                timer.Stop();
                LoginCustomer loginCustomer = new LoginCustomer();
                loginCustomer.Show();
                this.Hide();
            }
        }

        private void bSkip_Click(object sender, EventArgs e)
        {
            timer.Stop();
            LoginCustomer loginCustomer = new LoginCustomer();
            loginCustomer.Show();
            this.Hide();
        }

        private void TempResult_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
