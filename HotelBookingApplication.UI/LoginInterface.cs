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
    public partial class LoginInterface : Form
    {
        Context db;
        NewUserInterface newUserInterface;
        int reservationCustomerID;

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
                foreach (AppUser item in db.AppUsers.ToList())
                {
                    if (item.UserName == txtUserName.Text)
                        reservationCustomerID = item.CustomerID;
                }
                txtPassword.Text = txtUserName.Text = "";
                UsersReservations usersReservations = new UsersReservations(this, db, reservationCustomerID);
                usersReservations.Show();
                Hide();
                //ReservationInterface reservation = new ReservationInterface(this, db, reservationCustomerID);

            
                //reservation.Show();
                //Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı, lütfen tekrar deneyiniz!");
            }
        }
    }
}
