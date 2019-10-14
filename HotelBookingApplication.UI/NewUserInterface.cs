using HotelBookinApplication.DAL;
using HotelBookingApplication.BLL;
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
    public partial class NewUserInterface : Form
    {
        LoginInterface loginInterface;
        Context db;
        public NewUserInterface(LoginInterface login)
        {
            loginInterface = login;
            db = new Context();
            InitializeComponent();
        }

       

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            loginInterface.Show();
            this.Hide();

        }

        private void NewUserInterface_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi(grpRegister))
            {
                MessageBox.Show("Lütfen tüm boş alanları doldurunuz!");
                return;
            }
            Customer customer = new Customer()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                TCNo = txtTcNo.Text,
            };
            AppUser user = new AppUser()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
            };
            db.AppUsers.Add(user);
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Üye kaydı alınmıştır...");
            Metotlar.Temizle(grpRegister);
            loginInterface.Show();
            this.Hide();
        }
    }
}
