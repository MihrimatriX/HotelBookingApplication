namespace HotelBookingApplication.UI
{
    partial class UsersReservations
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
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniRezerve = new System.Windows.Forms.Button();
            this.lstRezervasyonlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(512, 28);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(0, 13);
            this.lblHosgeldiniz.TabIndex = 9;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(458, 282);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(93, 50);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnYeniRezerve
            // 
            this.btnYeniRezerve.Location = new System.Drawing.Point(571, 282);
            this.btnYeniRezerve.Name = "btnYeniRezerve";
            this.btnYeniRezerve.Size = new System.Drawing.Size(167, 50);
            this.btnYeniRezerve.TabIndex = 6;
            this.btnYeniRezerve.Text = "Yeni Rezervasyon";
            this.btnYeniRezerve.UseVisualStyleBackColor = true;
            this.btnYeniRezerve.Click += new System.EventHandler(this.BtnYeniRezerve_Click);
            // 
            // lstRezervasyonlar
            // 
            this.lstRezervasyonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.lstRezervasyonlar.GridLines = true;
            this.lstRezervasyonlar.HideSelection = false;
            this.lstRezervasyonlar.Location = new System.Drawing.Point(12, 12);
            this.lstRezervasyonlar.Name = "lstRezervasyonlar";
            this.lstRezervasyonlar.Size = new System.Drawing.Size(539, 249);
            this.lstRezervasyonlar.TabIndex = 5;
            this.lstRezervasyonlar.UseCompatibleStateImageBehavior = false;
            this.lstRezervasyonlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Giriş Tarihi";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Çıkış Tarihi";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rezervasyon Tipi";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ücret";
            this.columnHeader6.Width = 59;
            // 
            // UsersReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 344);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYeniRezerve);
            this.Controls.Add(this.lstRezervasyonlar);
            this.Name = "UsersReservations";
            this.Text = "UsersReservations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersReservations_FormClosed);
            this.Load += new System.EventHandler(this.UsersReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniRezerve;
        private System.Windows.Forms.ListView lstRezervasyonlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}