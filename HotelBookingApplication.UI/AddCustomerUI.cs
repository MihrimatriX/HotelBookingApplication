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
    public partial class AddCustomerUI : Form
    {
        ReservationInterface reservationInterface;
        Context db;
        int reservationID;
        int kalacakKisiSayisi;
        public AddCustomerUI(ReservationInterface res, Context context, int reser, int kalacak)
        {
            reservationInterface = res;
            db = context;
            reservationID = reser;
            kalacakKisiSayisi = kalacak;
            InitializeComponent();
        }
        int kacincidayim = 1;
        bool kaydedildiMi = false;
        private void AddCustomerUI_Load(object sender, EventArgs e)
        {
            lblKacinciKisi.Text = "1. Kişinin Bilgilerini Giriniz.";
        }
        private void BtnTamam_Click(object sender, EventArgs e)
        {
            if(txtAd.Text == "" || txtSoyad.Text == "" || txtTcNo.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz.");
                return;
            }
            else if (txtTcNo.Text.Length != 11)
            {
                MessageBox.Show("TC kimlik numarasını 11 haneli olarak giriniz.");
                return;
            }
                
            if (kacincidayim == kalacakKisiSayisi)
            {
                reservationInterface.usersReservations.Show();
                this.Hide();
            }
            foreach (Customer item in db.Customers.ToList())
            {
                if (item.TCNo == txtTcNo.Text)
                {
                    ReservationCustomer reservationCustomer = new ReservationCustomer()
                    {
                        ReservationID = reservationID,
                        CustomerID = item.CustomerID
                    };
                    db.ReservationCustomers.Add(reservationCustomer);
                    db.SaveChanges();
                    kaydedildiMi = true;

                }
            }
            if (!kaydedildiMi)
            {
                Customer customer = new Customer()
                {
                    FirstName = txtAd.Text,
                    LastName = txtSoyad.Text,
                    TCNo = txtTcNo.Text
                };
                db.Customers.Add(customer);
                db.SaveChanges();
                foreach(Customer item in db.Customers.ToList())
                {
                    if(item.TCNo == txtTcNo.Text)
                    {
                        ReservationCustomer reservationCustomer = new ReservationCustomer()
                        {
                            ReservationID = reservationID,
                            CustomerID = item.CustomerID
                        };
                        db.ReservationCustomers.Add(reservationCustomer);
                        db.SaveChanges();
                        kaydedildiMi = false;
                    }
                }
            }
            kacincidayim++;
            lblKacinciKisi.Text = string.Format("{0}. Kişinin Bilgilerini Giriniz.", kacincidayim);
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTcNo.Text = "";
        }

        private void TxtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AddCustomerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            reservationInterface.Show();
        }
    }
}
