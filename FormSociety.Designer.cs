namespace ProjectPemilu
{
    partial class FormSociety
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
            this.lNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lNoKTP = new System.Windows.Forms.Label();
            this.tbNoKTP = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.lAlamat = new System.Windows.Forms.Label();
            this.lKependudukan = new System.Windows.Forms.Label();
            this.rbWNA = new System.Windows.Forms.RadioButton();
            this.rbWNI = new System.Windows.Forms.RadioButton();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNama
            // 
            this.lNama.AutoSize = true;
            this.lNama.Location = new System.Drawing.Point(47, 84);
            this.lNama.Name = "lNama";
            this.lNama.Size = new System.Drawing.Size(35, 13);
            this.lNama.TabIndex = 21;
            this.lNama.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(101, 81);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(138, 20);
            this.tbNama.TabIndex = 20;
            // 
            // lNoKTP
            // 
            this.lNoKTP.AutoSize = true;
            this.lNoKTP.Location = new System.Drawing.Point(47, 58);
            this.lNoKTP.Name = "lNoKTP";
            this.lNoKTP.Size = new System.Drawing.Size(48, 13);
            this.lNoKTP.TabIndex = 19;
            this.lNoKTP.Text = "No. KTP";
            // 
            // tbNoKTP
            // 
            this.tbNoKTP.Location = new System.Drawing.Point(101, 55);
            this.tbNoKTP.Name = "tbNoKTP";
            this.tbNoKTP.ReadOnly = true;
            this.tbNoKTP.Size = new System.Drawing.Size(138, 20);
            this.tbNoKTP.TabIndex = 18;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(33, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(220, 20);
            this.lTitle.TabIndex = 15;
            this.lTitle.Text = "Form Pengubahan Society";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(164, 168);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 13;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lAlamat
            // 
            this.lAlamat.AutoSize = true;
            this.lAlamat.Location = new System.Drawing.Point(47, 110);
            this.lAlamat.Name = "lAlamat";
            this.lAlamat.Size = new System.Drawing.Size(39, 13);
            this.lAlamat.TabIndex = 23;
            this.lAlamat.Text = "Alamat";
            // 
            // lKependudukan
            // 
            this.lKependudukan.AutoSize = true;
            this.lKependudukan.Location = new System.Drawing.Point(47, 136);
            this.lKependudukan.Name = "lKependudukan";
            this.lKependudukan.Size = new System.Drawing.Size(80, 13);
            this.lKependudukan.TabIndex = 25;
            this.lKependudukan.Text = "Kependudukan";
            // 
            // rbWNA
            // 
            this.rbWNA.AutoSize = true;
            this.rbWNA.Location = new System.Drawing.Point(186, 134);
            this.rbWNA.Name = "rbWNA";
            this.rbWNA.Size = new System.Drawing.Size(51, 17);
            this.rbWNA.TabIndex = 29;
            this.rbWNA.TabStop = true;
            this.rbWNA.Text = "WNA";
            this.rbWNA.UseVisualStyleBackColor = true;
            // 
            // rbWNI
            // 
            this.rbWNI.AutoSize = true;
            this.rbWNI.Location = new System.Drawing.Point(133, 134);
            this.rbWNI.Name = "rbWNI";
            this.rbWNI.Size = new System.Drawing.Size(47, 17);
            this.rbWNI.TabIndex = 28;
            this.rbWNI.TabStop = true;
            this.rbWNI.Text = "WNI";
            this.rbWNI.UseVisualStyleBackColor = true;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(101, 107);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(138, 20);
            this.tbAlamat.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSociety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.rbWNA);
            this.Controls.Add(this.rbWNI);
            this.Controls.Add(this.lKependudukan);
            this.Controls.Add(this.lAlamat);
            this.Controls.Add(this.lNama);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lNoKTP);
            this.Controls.Add(this.tbNoKTP);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.bSave);
            this.Name = "FormSociety";
            this.Text = "FormSociety";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lNama;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lNoKTP;
        private System.Windows.Forms.TextBox tbNoKTP;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lAlamat;
        private System.Windows.Forms.Label lKependudukan;
        private System.Windows.Forms.RadioButton rbWNA;
        private System.Windows.Forms.RadioButton rbWNI;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Button button1;
    }
}