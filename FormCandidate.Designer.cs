namespace ProjectPemilu
{
    partial class FormCandidate
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
            this.bSave = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbNoUrut = new System.Windows.Forms.TextBox();
            this.lNoUrut = new System.Windows.Forms.Label();
            this.lNoKTP = new System.Windows.Forms.Label();
            this.tbNoKTP = new System.Windows.Forms.TextBox();
            this.lJabatan = new System.Windows.Forms.Label();
            this.lQuote = new System.Windows.Forms.Label();
            this.tbQuote = new System.Windows.Forms.TextBox();
            this.rbWakil = new System.Windows.Forms.RadioButton();
            this.rbKetua = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(171, 165);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(57, 165);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(32, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(243, 20);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Form Pengubahan Candidate";
            // 
            // tbNoUrut
            // 
            this.tbNoUrut.Location = new System.Drawing.Point(108, 79);
            this.tbNoUrut.Name = "tbNoUrut";
            this.tbNoUrut.Size = new System.Drawing.Size(138, 20);
            this.tbNoUrut.TabIndex = 3;
            // 
            // lNoUrut
            // 
            this.lNoUrut.AutoSize = true;
            this.lNoUrut.Location = new System.Drawing.Point(54, 82);
            this.lNoUrut.Name = "lNoUrut";
            this.lNoUrut.Size = new System.Drawing.Size(47, 13);
            this.lNoUrut.TabIndex = 4;
            this.lNoUrut.Text = "No. Urut";
            // 
            // lNoKTP
            // 
            this.lNoKTP.AutoSize = true;
            this.lNoKTP.Location = new System.Drawing.Point(54, 56);
            this.lNoKTP.Name = "lNoKTP";
            this.lNoKTP.Size = new System.Drawing.Size(48, 13);
            this.lNoKTP.TabIndex = 6;
            this.lNoKTP.Text = "No. KTP";
            // 
            // tbNoKTP
            // 
            this.tbNoKTP.Location = new System.Drawing.Point(108, 53);
            this.tbNoKTP.Name = "tbNoKTP";
            this.tbNoKTP.ReadOnly = true;
            this.tbNoKTP.Size = new System.Drawing.Size(138, 20);
            this.tbNoKTP.TabIndex = 5;
            // 
            // lJabatan
            // 
            this.lJabatan.AutoSize = true;
            this.lJabatan.Location = new System.Drawing.Point(54, 108);
            this.lJabatan.Name = "lJabatan";
            this.lJabatan.Size = new System.Drawing.Size(45, 13);
            this.lJabatan.TabIndex = 10;
            this.lJabatan.Text = "Jabatan";
            // 
            // lQuote
            // 
            this.lQuote.AutoSize = true;
            this.lQuote.Location = new System.Drawing.Point(54, 134);
            this.lQuote.Name = "lQuote";
            this.lQuote.Size = new System.Drawing.Size(36, 13);
            this.lQuote.TabIndex = 12;
            this.lQuote.Text = "Quote";
            // 
            // tbQuote
            // 
            this.tbQuote.Location = new System.Drawing.Point(108, 131);
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.Size = new System.Drawing.Size(138, 20);
            this.tbQuote.TabIndex = 11;
            // 
            // rbWakil
            // 
            this.rbWakil.AutoSize = true;
            this.rbWakil.Location = new System.Drawing.Point(161, 108);
            this.rbWakil.Name = "rbWakil";
            this.rbWakil.Size = new System.Drawing.Size(52, 17);
            this.rbWakil.TabIndex = 31;
            this.rbWakil.TabStop = true;
            this.rbWakil.Text = "Wakil";
            this.rbWakil.UseVisualStyleBackColor = true;
            // 
            // rbKetua
            // 
            this.rbKetua.AutoSize = true;
            this.rbKetua.Location = new System.Drawing.Point(108, 108);
            this.rbKetua.Name = "rbKetua";
            this.rbKetua.Size = new System.Drawing.Size(53, 17);
            this.rbKetua.TabIndex = 30;
            this.rbKetua.TabStop = true;
            this.rbKetua.Text = "Ketua";
            this.rbKetua.UseVisualStyleBackColor = true;
            // 
            // FormCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 220);
            this.Controls.Add(this.rbWakil);
            this.Controls.Add(this.rbKetua);
            this.Controls.Add(this.lQuote);
            this.Controls.Add(this.tbQuote);
            this.Controls.Add(this.lJabatan);
            this.Controls.Add(this.lNoKTP);
            this.Controls.Add(this.tbNoKTP);
            this.Controls.Add(this.lNoUrut);
            this.Controls.Add(this.tbNoUrut);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSave);
            this.Name = "FormCandidate";
            this.Text = "FormCandidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbNoUrut;
        private System.Windows.Forms.Label lNoUrut;
        private System.Windows.Forms.Label lNoKTP;
        private System.Windows.Forms.TextBox tbNoKTP;
        private System.Windows.Forms.Label lJabatan;
        private System.Windows.Forms.Label lQuote;
        private System.Windows.Forms.TextBox tbQuote;
        private System.Windows.Forms.RadioButton rbWakil;
        private System.Windows.Forms.RadioButton rbKetua;
    }
}