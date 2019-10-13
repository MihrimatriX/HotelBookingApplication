using HotelBookingApplication.DAL;
using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingApplication.UI
{
    public partial class Form2 : Form
    {
        Form1 anaForm;
        Context db;
        public Form2(Form1 form1)
        {
            anaForm = form1;
            db = new Context();
            InitializeComponent();
        }
        
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi(grpKayit))
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurunuz!");
                return;
            }
            Musteri musteri = new Musteri()
            {
                Ad = txtAdKayit.Text,
                Soyad = txtSoyadKayit.Text,
                TcNo = txtTCNoKayit.Text,
            };
            User kullanici = new User()
            {
                UserName = txtKullaniciKayit.Text,
                Password = txtSifreKayit.Text,                        
            };
            db.UserTablosu.Add(kullanici);
            db.MusteriTablosu.Add(musteri);
            db.SaveChanges();
            MessageBox.Show("Üye kaydı alınmıştır...");
            anaForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtSifreKayit.PasswordChar = '*';
        }

        private void BtnGirisEkrani_Click(object sender, EventArgs e)
        {
            anaForm.Show();
            this.Hide();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Metotlar.Temizle(grpKayit);
        }
    }
}
