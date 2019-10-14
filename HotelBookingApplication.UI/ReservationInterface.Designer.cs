namespace HotelBookingApplication.UI
{
    partial class ReservationInterface
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
            this.nmrOda = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCesitler = new System.Windows.Forms.ComboBox();
            this.btnOdalariListele = new System.Windows.Forms.Button();
            this.klabel3 = new System.Windows.Forms.Label();
            this.nmrKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.grpOdalar = new System.Windows.Forms.GroupBox();
            this.btnRezervasyonuTamamla = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.grpListeleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListeleme
            // 
            this.grpListeleme.Controls.Add(this.nmrOda);
            this.grpListeleme.Controls.Add(this.label4);
            this.grpListeleme.Controls.Add(this.label3);
            this.grpListeleme.Controls.Add(this.cmbCesitler);
            this.grpListeleme.Controls.Add(this.btnOdalariListele);
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
            // nmrOda
            // 
            this.nmrOda.Location = new System.Drawing.Point(24, 167);
            this.nmrOda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrOda.Name = "nmrOda";
            this.nmrOda.Size = new System.Drawing.Size(200, 20);
            this.nmrOda.TabIndex = 19;
            this.nmrOda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Oda Sayısı:";
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
            // cmbCesitler
            // 
            this.cmbCesitler.FormattingEnabled = true;
            this.cmbCesitler.Items.AddRange(new object[] {
            "Standart",
            "Full",
            "Full + Full"});
            this.cmbCesitler.Location = new System.Drawing.Point(338, 112);
            this.cmbCesitler.Name = "cmbCesitler";
            this.cmbCesitler.Size = new System.Drawing.Size(200, 21);
            this.cmbCesitler.TabIndex = 16;
            // 
            // btnOdalariListele
            // 
            this.btnOdalariListele.Location = new System.Drawing.Point(338, 158);
            this.btnOdalariListele.Name = "btnOdalariListele";
            this.btnOdalariListele.Size = new System.Drawing.Size(200, 35);
            this.btnOdalariListele.TabIndex = 15;
            this.btnOdalariListele.Text = "Odaları Listele";
            this.btnOdalariListele.UseVisualStyleBackColor = true;
            this.btnOdalariListele.Click += new System.EventHandler(this.BtnOdalariListele_Click);
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
            this.nmrKisiSayisi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrKisiSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrKisiSayisi.Name = "nmrKisiSayisi";
            this.nmrKisiSayisi.Size = new System.Drawing.Size(200, 20);
            this.nmrKisiSayisi.TabIndex = 12;
            this.nmrKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrKisiSayisi.ValueChanged += new System.EventHandler(this.NmrKisiSayisi_ValueChanged_1);
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
            this.dtGirisTarihi.ValueChanged += new System.EventHandler(this.DtGirisTarihi_ValueChanged);
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
            // btnRezervasyonuTamamla
            // 
            this.btnRezervasyonuTamamla.Location = new System.Drawing.Point(527, 507);
            this.btnRezervasyonuTamamla.Name = "btnRezervasyonuTamamla";
            this.btnRezervasyonuTamamla.Size = new System.Drawing.Size(160, 39);
            this.btnRezervasyonuTamamla.TabIndex = 2;
            this.btnRezervasyonuTamamla.Text = "Rezervasyonu Tamamla";
            this.btnRezervasyonuTamamla.UseVisualStyleBackColor = true;
            this.btnRezervasyonuTamamla.Click += new System.EventHandler(this.BtnRezervasyonuTamamla_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(332, 520);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 13);
            this.lblMoney.TabIndex = 3;
            // 
            // ReservationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 558);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnRezervasyonuTamamla);
            this.Controls.Add(this.grpOdalar);
            this.Controls.Add(this.grpListeleme);
            this.Name = "ReservationInterface";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.grpListeleme.ResumeLayout(false);
            this.grpListeleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListeleme;
        private System.Windows.Forms.Button btnOdalariListele;
        private System.Windows.Forms.Label klabel3;
        private System.Windows.Forms.NumericUpDown nmrKisiSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.GroupBox grpOdalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCesitler;
        private System.Windows.Forms.Button btnRezervasyonuTamamla;
        private System.Windows.Forms.NumericUpDown nmrOda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoney;
    }
}