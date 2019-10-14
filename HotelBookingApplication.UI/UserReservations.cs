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
    public partial class UserReservations : Form
    {
        LoginInterface loginInterface;
        Reservation reservation;
        public UserReservations(LoginInterface login)
        {
            loginInterface = login;
            InitializeComponent();
        }
        
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            loginInterface.Show();

            this.Close();
         
        }

        private void UserReservations_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginInterface.Show();

        }

        private void BtnYeniRezerve_Click(object sender, EventArgs e)
        {
            reservation = new Reservation();
            reservation.Show();
            this.Close();
            loginInterface.Hide();                
        }
    }
}
