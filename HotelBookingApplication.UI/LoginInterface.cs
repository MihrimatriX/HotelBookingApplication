using HotelBookinApplication.DAL;
using HotelBookingApplication.BLL;
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
    public partial class LoginInterface : Form
    {
        Context db;
        ReservationInterface reservation;
        NewUserInterface newUserInterface;

        public LoginInterface()
        {
            InitializeComponent();
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            newUserInterface = new NewUserInterface(this,db);
            Hide();
            newUserInterface.Show();
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {
            Connection.AddRoom(20);
            Connection.AddOptions();
            db = new Context();
            txtPassword.PasswordChar = '*';
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (db.AppUsers.FirstOrDefault(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text) != null)
            {
                txtPassword.Text = txtUserName.Text = "";
                UserReservations userReservations= new UserReservations(this , db);
                userReservations.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı, lütfen tekrar deneyiniz!");
            }
        }
    }
}
