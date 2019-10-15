using HotelBookinApplication.DAL;
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
    public partial class UsersReservations : Form
    {
        LoginInterface loginInterface;
        Context db;
        int reservationCustomerID;
        public UsersReservations(LoginInterface login, Context context, int reser)
        {
            loginInterface = login;
            db = context;
            reservationCustomerID = reser;
            InitializeComponent();
        }
        int odaSayisi;
        int kisiSayisi;
        private void UsersReservations_Load(object sender, EventArgs e)
        {
            foreach (Reservation item in db.Reservations)
            {
                if (item.CustomerID == reservationCustomerID)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.ArrivalDate.ToString();
                    lvi.SubItems.Add(item.DepartureDate.ToString());
                    lvi.SubItems.Add(item.OptionID.ToString());
                    lvi.SubItems.Add(item.Price.ToString());
                    lstRezervasyonlar.Items.Add(lvi);
                }
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersReservations_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginInterface.Show();
        }

        private void BtnYeniRezerve_Click(object sender, EventArgs e)
        {
            ReservationInterface reservationInterface = new ReservationInterface(this, db, reservationCustomerID);
            reservationInterface.Show();
            this.Hide();
        }
    }
}
