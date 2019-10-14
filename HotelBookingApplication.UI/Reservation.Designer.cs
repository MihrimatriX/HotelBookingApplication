namespace HotelBookingApplication.UI
{
    partial class Reservation
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
            this.grpListeleme = new System.Windows.Forms.GroupBox();
            this.btnOdalariListele = new System.Windows.Forms.Button();
            this.lblUyari = new System.Windows.Forms.Label();
            this.klabel3 = new System.Windows.Forms.Label();
            this.nmrKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.grpOdalar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRezervasyonuTamamla = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.grpListeleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListeleme
            // 
            this.grpListeleme.Controls.Add(this.label3);
            this.grpListeleme.Controls.Add(this.comboBox1);
            this.grpListeleme.Controls.Add(this.btnOdalariListele);
            this.grpListeleme.Controls.Add(this.lblUyari);
            this.grpListeleme.Controls.Add(this.klabel3);
            this.grpListeleme.Controls.Add(this.nmrKisiSayisi);
            this.grpListeleme.Controls.Add(this.label2);
            this.grpListeleme.Controls.Add(this.dtCikisTarihi);
            this.grpListeleme.Controls.Add(this.label1);
            this.grpListeleme.Controls.Add(this.dtGirisTarihi);
            this.grpListeleme.Location = new System.Drawing.Point(22, 12);
            this.grpListeleme.Name = "grpListeleme";
            this.grpListeleme.Size = new System.Drawing.Size(665, 205);
            this.grpListeleme.TabIndex = 0;
            this.grpListeleme.TabStop = false;
            // 
            // btnOdalariListele
            // 
            this.btnOdalariListele.Location = new System.Drawing.Point(338, 158);
            this.btnOdalariListele.Name = "btnOdalariListele";
            this.btnOdalariListele.Size = new System.Drawing.Size(200, 35);
            this.btnOdalariListele.TabIndex = 15;
            this.btnOdalariListele.Text = "Odaları Listele";
            this.btnOdalariListele.UseVisualStyleBackColor = true;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(31, 158);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 14;
            // 
            // klabel3
            // 
            this.klabel3.AutoSize = true;
            this.klabel3.Location = new System.Drawing.Point(21, 85);
            this.klabel3.Name = "klabel3";
            this.klabel3.Size = new System.Drawing.Size(133, 13);
            this.klabel3.TabIndex = 13;
            this.klabel3.Text = "Konaklayacak Kişi Sayısı : ";
            // 
            // nmrKisiSayisi
            // 
            this.nmrKisiSayisi.Location = new System.Drawing.Point(24, 112);
            this.nmrKisiSayisi.Name = "nmrKisiSayisi";
            this.nmrKisiSayisi.Size = new System.Drawing.Size(120, 20);
            this.nmrKisiSayisi.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Çıkış Tarihi : ";
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(338, 45);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtCikisTarihi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giriş Tarihi : ";
            // 
            // dtGirisTarihi
            // 
            this.dtGirisTarihi.Location = new System.Drawing.Point(24, 45);
            this.dtGirisTarihi.Name = "dtGirisTarihi";
            this.dtGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtGirisTarihi.TabIndex = 8;
            // 
            // grpOdalar
            // 
            this.grpOdalar.Location = new System.Drawing.Point(22, 223);
            this.grpOdalar.Name = "grpOdalar";
            this.grpOdalar.Size = new System.Drawing.Size(665, 278);
            this.grpOdalar.TabIndex = 1;
            this.grpOdalar.TabStop = false;
            this.grpOdalar.Text = "Odalar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standart",
            "Full",
            "Full+Full"});
            this.comboBox1.Location = new System.Drawing.Point(338, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rezervasyon Çeşidi : ";
            // 
            // btnRezervasyonuTamamla
            // 
            this.btnRezervasyonuTamamla.Location = new System.Drawing.Point(527, 507);
            this.btnRezervasyonuTamamla.Name = "btnRezervasyonuTamamla";
            this.btnRezervasyonuTamamla.Size = new System.Drawing.Size(160, 39);
            this.btnRezervasyonuTamamla.TabIndex = 2;
            this.btnRezervasyonuTamamla.Text = "Rezervasyonu Tamamla";
            this.btnRezervasyonuTamamla.UseVisualStyleBackColor = true;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(43, 520);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(0, 13);
            this.lblUcret.TabIndex = 3;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.btnRezervasyonuTamamla);
            this.Controls.Add(this.grpOdalar);
            this.Controls.Add(this.grpListeleme);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.grpListeleme.ResumeLayout(false);
            this.grpListeleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListeleme;
        private System.Windows.Forms.Button btnOdalariListele;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label klabel3;
        private System.Windows.Forms.NumericUpDown nmrKisiSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.GroupBox grpOdalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRezervasyonuTamamla;
        private System.Windows.Forms.Label lblUcret;
    }
}