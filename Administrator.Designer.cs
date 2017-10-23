namespace ProjectPemilu
{
    partial class Administrator
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
            this.operationTab = new System.Windows.Forms.TabControl();
            this.candidate = new System.Windows.Forms.TabPage();
            this.bAdd = new System.Windows.Forms.Button();
            this.dataGridCandidate = new System.Windows.Forms.DataGridView();
            this.editCandidate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeCandidate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.society = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridSociety = new System.Windows.Forms.DataGridView();
            this.editSociety = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeSociety = new System.Windows.Forms.DataGridViewButtonColumn();
            this.printResult = new System.Windows.Forms.TabPage();
            this.bReset = new System.Windows.Forms.Button();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.lHi = new System.Windows.Forms.Label();
            this.bLogout = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.operationTab.SuspendLayout();
            this.candidate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandidate)).BeginInit();
            this.society.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSociety)).BeginInit();
            this.printResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // operationTab
            // 
            this.operationTab.Controls.Add(this.candidate);
            this.operationTab.Controls.Add(this.society);
            this.operationTab.Controls.Add(this.printResult);
            this.operationTab.Location = new System.Drawing.Point(-2, 27);
            this.operationTab.Name = "operationTab";
            this.operationTab.SelectedIndex = 0;
            this.operationTab.Size = new System.Drawing.Size(782, 431);
            this.operationTab.TabIndex = 0;
            // 
            // candidate
            // 
            this.candidate.Controls.Add(this.bAdd);
            this.candidate.Controls.Add(this.dataGridCandidate);
            this.candidate.Location = new System.Drawing.Point(4, 22);
            this.candidate.Name = "candidate";
            this.candidate.Padding = new System.Windows.Forms.Padding(3);
            this.candidate.Size = new System.Drawing.Size(774, 405);
            this.candidate.TabIndex = 0;
            this.candidate.Text = "Candidate";
            this.candidate.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Honeydew;
            this.bAdd.Location = new System.Drawing.Point(679, 6);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(89, 23);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Add Candidate";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dataGridCandidate
            // 
            this.dataGridCandidate.AllowUserToAddRows = false;
            this.dataGridCandidate.AllowUserToDeleteRows = false;
            this.dataGridCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editCandidate,
            this.removeCandidate});
            this.dataGridCandidate.Location = new System.Drawing.Point(6, 32);
            this.dataGridCandidate.Name = "dataGridCandidate";
            this.dataGridCandidate.ReadOnly = true;
            this.dataGridCandidate.Size = new System.Drawing.Size(762, 367);
            this.dataGridCandidate.TabIndex = 1;
            this.dataGridCandidate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCandidate_CellContentClick);
            // 
            // editCandidate
            // 
            this.editCandidate.HeaderText = "Edit";
            this.editCandidate.Name = "editCandidate";
            this.editCandidate.ReadOnly = true;
            this.editCandidate.Text = "";
            this.editCandidate.Width = 50;
            // 
            // removeCandidate
            // 
            this.removeCandidate.HeaderText = "Remove";
            this.removeCandidate.Name = "removeCandidate";
            this.removeCandidate.ReadOnly = true;
            this.removeCandidate.Width = 50;
            // 
            // society
            // 
            this.society.Controls.Add(this.button1);
            this.society.Controls.Add(this.dataGridSociety);
            this.society.Location = new System.Drawing.Point(4, 22);
            this.society.Name = "society";
            this.society.Padding = new System.Windows.Forms.Padding(3);
            this.society.Size = new System.Drawing.Size(774, 405);
            this.society.TabIndex = 1;
            this.society.Text = "Society";
            this.society.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(677, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Society";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridSociety
            // 
            this.dataGridSociety.AllowUserToAddRows = false;
            this.dataGridSociety.AllowUserToDeleteRows = false;
            this.dataGridSociety.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSociety.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editSociety,
            this.removeSociety});
            this.dataGridSociety.Location = new System.Drawing.Point(6, 32);
            this.dataGridSociety.Name = "dataGridSociety";
            this.dataGridSociety.ReadOnly = true;
            this.dataGridSociety.Size = new System.Drawing.Size(760, 367);
            this.dataGridSociety.TabIndex = 2;
            this.dataGridSociety.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSociety_CellContentClick);
            // 
            // editSociety
            // 
            this.editSociety.HeaderText = "Edit";
            this.editSociety.Name = "editSociety";
            this.editSociety.ReadOnly = true;
            this.editSociety.Width = 50;
            // 
            // removeSociety
            // 
            this.removeSociety.HeaderText = "Remove";
            this.removeSociety.Name = "removeSociety";
            this.removeSociety.ReadOnly = true;
            this.removeSociety.Width = 50;
            // 
            // printResult
            // 
            this.printResult.Controls.Add(this.bReset);
            this.printResult.Controls.Add(this.dataGridResult);
            this.printResult.Location = new System.Drawing.Point(4, 22);
            this.printResult.Name = "printResult";
            this.printResult.Padding = new System.Windows.Forms.Padding(3);
            this.printResult.Size = new System.Drawing.Size(774, 405);
            this.printResult.TabIndex = 2;
            this.printResult.Text = "Vote Result";
            this.printResult.UseVisualStyleBackColor = true;
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.Honeydew;
            this.bReset.Location = new System.Drawing.Point(674, 6);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(94, 23);
            this.bReset.TabIndex = 5;
            this.bReset.Text = "Reset Voting";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // dataGridResult
            // 
            this.dataGridResult.AllowUserToAddRows = false;
            this.dataGridResult.AllowUserToDeleteRows = false;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Location = new System.Drawing.Point(6, 32);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.Size = new System.Drawing.Size(762, 367);
            this.dataGridResult.TabIndex = 3;
            // 
            // lHi
            // 
            this.lHi.AutoSize = true;
            this.lHi.Location = new System.Drawing.Point(12, 4);
            this.lHi.Name = "lHi";
            this.lHi.Size = new System.Drawing.Size(23, 13);
            this.lHi.TabIndex = 2;
            this.lHi.Text = "Hi, ";
            // 
            // bLogout
            // 
            this.bLogout.BackColor = System.Drawing.Color.Honeydew;
            this.bLogout.Location = new System.Drawing.Point(701, 12);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(75, 23);
            this.bLogout.TabIndex = 3;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = false;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.Honeydew;
            this.bRefresh.Location = new System.Drawing.Point(584, 12);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(94, 23);
            this.bRefresh.TabIndex = 4;
            this.bRefresh.Text = "Refresh Table";
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.lHi);
            this.Controls.Add(this.operationTab);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Activated += new System.EventHandler(this.Administrator_Activated);
            this.operationTab.ResumeLayout(false);
            this.candidate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandidate)).EndInit();
            this.society.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSociety)).EndInit();
            this.printResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl operationTab;
        private System.Windows.Forms.TabPage candidate;
        private System.Windows.Forms.TabPage society;
        private System.Windows.Forms.TabPage printResult;
        private System.Windows.Forms.DataGridView dataGridCandidate;
        private System.Windows.Forms.DataGridView dataGridSociety;
        private System.Windows.Forms.DataGridViewButtonColumn editCandidate;
        private System.Windows.Forms.DataGridViewButtonColumn removeCandidate;
        private System.Windows.Forms.DataGridViewButtonColumn editSociety;
        private System.Windows.Forms.DataGridViewButtonColumn removeSociety;
        private System.Windows.Forms.Label lHi;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.DataGridView dataGridResult;
    }
}