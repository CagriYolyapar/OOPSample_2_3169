namespace OOPSample_2
{
    partial class Form2
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.cmbLablar = new System.Windows.Forms.ComboBox();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 68);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 0;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(12, 138);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 22);
            this.txtSoyisim.TabIndex = 0;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(37, 177);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciEkle.TabIndex = 1;
            this.btnOgrenciEkle.Text = "Ogrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.ItemHeight = 16;
            this.lstOgrenciler.Location = new System.Drawing.Point(526, 26);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(235, 260);
            this.lstOgrenciler.TabIndex = 2;
            this.lstOgrenciler.Click += new System.EventHandler(this.lstOgrenciler_Click);
            // 
            // cmbLablar
            // 
            this.cmbLablar.FormattingEnabled = true;
            this.cmbLablar.Location = new System.Drawing.Point(12, 12);
            this.cmbLablar.Name = "cmbLablar";
            this.cmbLablar.Size = new System.Drawing.Size(121, 24);
            this.cmbLablar.TabIndex = 3;
            this.cmbLablar.SelectedIndexChanged += new System.EventHandler(this.cmbLablar_SelectedIndexChanged);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOgrenci.Location = new System.Drawing.Point(217, 347);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(331, 52);
            this.lblOgrenci.TabIndex = 4;
            // 
            // lblLab
            // 
            this.lblLab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLab.Location = new System.Drawing.Point(191, 12);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(132, 28);
            this.lblLab.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.cmbLablar);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.ComboBox cmbLablar;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.Label lblLab;
    }
}