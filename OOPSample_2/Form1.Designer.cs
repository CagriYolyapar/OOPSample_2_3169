namespace OOPSample_2
{
    partial class Form1
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
            this.txtLabNo = new System.Windows.Forms.TextBox();
            this.btnLabEkle = new System.Windows.Forms.Button();
            this.lstLablar = new System.Windows.Forms.ListBox();
            this.lblLab = new System.Windows.Forms.Label();
            this.btnFormGec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLabNo
            // 
            this.txtLabNo.Location = new System.Drawing.Point(89, 56);
            this.txtLabNo.Name = "txtLabNo";
            this.txtLabNo.Size = new System.Drawing.Size(100, 22);
            this.txtLabNo.TabIndex = 0;
            // 
            // btnLabEkle
            // 
            this.btnLabEkle.Location = new System.Drawing.Point(104, 169);
            this.btnLabEkle.Name = "btnLabEkle";
            this.btnLabEkle.Size = new System.Drawing.Size(75, 23);
            this.btnLabEkle.TabIndex = 1;
            this.btnLabEkle.Text = "Lab Ekle";
            this.btnLabEkle.UseVisualStyleBackColor = true;
            this.btnLabEkle.Click += new System.EventHandler(this.btnLabEkle_Click);
            // 
            // lstLablar
            // 
            this.lstLablar.FormattingEnabled = true;
            this.lstLablar.ItemHeight = 16;
            this.lstLablar.Location = new System.Drawing.Point(272, 35);
            this.lstLablar.Name = "lstLablar";
            this.lstLablar.Size = new System.Drawing.Size(195, 276);
            this.lstLablar.TabIndex = 2;
            this.lstLablar.Click += new System.EventHandler(this.lstLablar_Click);
            // 
            // lblLab
            // 
            this.lblLab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLab.Location = new System.Drawing.Point(295, 340);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(345, 51);
            this.lblLab.TabIndex = 3;
            // 
            // btnFormGec
            // 
            this.btnFormGec.Location = new System.Drawing.Point(645, 102);
            this.btnFormGec.Name = "btnFormGec";
            this.btnFormGec.Size = new System.Drawing.Size(75, 23);
            this.btnFormGec.TabIndex = 4;
            this.btnFormGec.Text = "Form2";
            this.btnFormGec.UseVisualStyleBackColor = true;
            this.btnFormGec.Click += new System.EventHandler(this.btnFormGec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormGec);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lstLablar);
            this.Controls.Add(this.btnLabEkle);
            this.Controls.Add(this.txtLabNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLabNo;
        private System.Windows.Forms.Button btnLabEkle;
        private System.Windows.Forms.ListBox lstLablar;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Button btnFormGec;
    }
}

