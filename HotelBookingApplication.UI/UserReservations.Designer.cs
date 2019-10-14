namespace HotelBookingApplication.UI
{
    partial class UserReservations
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeniRezerve = new System.Windows.Forms.Button();
            this.btnİptalEt = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 225);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kişi Sayısı";
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Oda Sayısı";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ücret";
            this.columnHeader6.Width = 59;
            // 
            // btnYeniRezerve
            // 
            this.btnYeniRezerve.Location = new System.Drawing.Point(515, 258);
            this.btnYeniRezerve.Name = "btnYeniRezerve";
            this.btnYeniRezerve.Size = new System.Drawing.Size(167, 50);
            this.btnYeniRezerve.TabIndex = 1;
            this.btnYeniRezerve.Text = "Yeni Rezervasyon";
            this.btnYeniRezerve.UseVisualStyleBackColor = true;
            this.btnYeniRezerve.Click += new System.EventHandler(this.BtnYeniRezerve_Click);
            // 
            // btnİptalEt
            // 
            this.btnİptalEt.Location = new System.Drawing.Point(364, 258);
            this.btnİptalEt.Name = "btnİptalEt";
            this.btnİptalEt.Size = new System.Drawing.Size(125, 50);
            this.btnİptalEt.TabIndex = 2;
            this.btnİptalEt.Text = "İptal Et";
            this.btnİptalEt.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(243, 258);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(93, 50);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(512, 28);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(0, 13);
            this.lblHosgeldiniz.TabIndex = 4;
            // 
            // UserReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 320);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnİptalEt);
            this.Controls.Add(this.btnYeniRezerve);
            this.Controls.Add(this.listView1);
            this.Name = "UserReservations";
            this.Text = "UserReservations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserReservations_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYeniRezerve;
        private System.Windows.Forms.Button btnİptalEt;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblHosgeldiniz;
    }
}