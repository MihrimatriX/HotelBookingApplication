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
    public partial class Form1 : Form
    {
        Context db;
        public Form1()
        {            
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Context();
            txtSifre.PasswordChar = '*';            
        }
        
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (db.UserTablosu.FirstOrDefault(x => x.UserName == txtKullanici.Text && x.Password == txtSifre.Text) != null)
            {
                txtKullanici.Text = txtSifre.Text = "";
                form3 = new Form3();
                form3.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı, lütfen tekrar deneyiniz!");
            }
        }
        Form2 form2;
        Form3 form3;
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            Hide();
            form2.Show();
        }
    }
}
