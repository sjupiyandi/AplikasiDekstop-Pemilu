namespace ProjectPemilu
{
    partial class Voting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lHi = new System.Windows.Forms.Label();
            this.lInfo = new System.Windows.Forms.Label();
            this.lNama = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silahkan Memilih Candidate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lHi
            // 
            this.lHi.AutoSize = true;
            this.lHi.Location = new System.Drawing.Point(32, 49);
            this.lHi.Name = "lHi";
            this.lHi.Size = new System.Drawing.Size(23, 13);
            this.lHi.TabIndex = 2;
            this.lHi.Text = "Hi, ";
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(503, 49);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(254, 13);
            this.lInfo.TabIndex = 3;
            this.lInfo.Text = "Pilih dengan melakukan klik pada gambar candidate";
            // 
            // lNama
            // 
            this.lNama.AutoSize = true;
            this.lNama.Location = new System.Drawing.Point(52, 49);
            this.lNama.Name = "lNama";
            this.lNama.Size = new System.Drawing.Size(0, 13);
            this.lNama.TabIndex = 4;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(26, 75);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(735, 139);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lNama);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.lHi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Voting";
            this.Text = "Voting";
            this.Load += new System.EventHandler(this.Voting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lHi;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Label lNama;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}