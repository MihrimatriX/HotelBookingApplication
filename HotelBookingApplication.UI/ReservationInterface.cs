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
    public partial class ReservationInterface : Form
    {
        UserReservations userReservations;
        Context db;
        public ReservationInterface(UserReservations user, Context context)
        {
            userReservations = user;
            db = context;
            InitializeComponent();
        }

        private void NmrKisiSayisi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnRezervasyonuTamamla_Click(object sender, EventArgs e)
        {

        }
        private void Reservation_Load(object sender, EventArgs e)
        {
            cmbCesitler.DataSource = db.Options.ToList();
            cmbCesitler.DisplayMember = "OptionName";
            cmbCesitler.ValueMember = "OptionID";
            nmrOda.Maximum = nmrOda.Value;
            dtGirisTarihi.MinDate = DateTime.Now;

        }
        decimal roomPrice;
        decimal price;
        int minNumberOfRooms = 0;
        TimeSpan kalinacakGun;
        int kalinanGun;
        int haftaSonu = 0;
        private void BtnOdalariListele_Click(object sender, EventArgs e)
        {
            grpOdalar.Controls.Clear();
            int konumX = 0;
            int konumY = 0;
            int k = 1;
            for (int i = 0; i < 4; i++)
            {
                konumX = 0;
                for (int j = 0; j < 5; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Height = 70;
                    pictureBox.Width = 70;
                    pictureBox.Top = konumY;
                    pictureBox.Left = konumX;
                    pictureBox.Image = Image.FromFile("../image/bedroom.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.BackColor = Color.Green;
                    pictureBox.Name = k.ToString();
                    pictureBox.Click += PictureBox_Click;
                    grpOdalar.Controls.Add(pictureBox);
                    konumX = konumX + 70;
                    k++;
                }
                konumY += 70;

            }
            List<ReservationRoom> reservationRooms = new List<ReservationRoom>();
            for (DateTime dateTime = dtGirisTarihi.Value; dtCikisTarihi.Value.CompareTo(dateTime) > 0; dateTime = dateTime.AddDays(1.0))
            {
                foreach (Reservation item in db.Reservations.ToList())
                {
                    if (item.ArrivalDate < dateTime && item.DepartureDate > dateTime)
                    {
                        // select * from ReservationRooms where ReservationID = (select ReservationID from Reservations where ReservationID = 1)  
                        List<ReservationRoom> rooms = db.ReservationRooms.Where(x => x.ReservationID == item.RezervationID).ToList();
                        reservationRooms.AddRange(rooms);
                    }
                }
            }
            foreach (ReservationRoom item in reservationRooms)
            {
                foreach (PictureBox item2 in grpOdalar.Controls)
                {
                    if (item.RoomID == int.Parse(item2.Name))
                    {
                        item2.BackColor = Color.Red;
                        item2.Enabled = false;
                    }

                }
            }
            switch(cmbCesitler.SelectedIndex)
            {
                case 0:
                    roomPrice = 100;
                    break;
                case 1:
                    roomPrice = 150;
                    break;
                case 2:
                    roomPrice = 200;
                    break;
            }
            if(nmrKisiSayisi.Value % 3 == 0)
            {
                price = nmrOda.Value * roomPrice * 1.2m;
            }
            else if (nmrKisiSayisi.Value % 3 == 1)
            {
                price = (nmrOda.Value * roomPrice * 1.2m) + (roomPrice * 0.8m);
            }
            else if (nmrKisiSayisi.Value % 3 == 2)
            {
                price = (nmrOda.Value * roomPrice * 1.2m) + (roomPrice);
            }
            kalinacakGun = dtCikisTarihi.Value - dtGirisTarihi.Value;
            kalinanGun = (int)kalinacakGun.TotalDays;
            price = price * kalinanGun;
            for (DateTime dateTime = dtGirisTarihi.Value; dtCikisTarihi.Value.CompareTo(dateTime) > 0; dateTime = dateTime.AddDays(1.0))
            {
                if(dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday )
                {
                    haftaSonu++;
                }
            }
            price = (price * (kalinanGun - haftaSonu)) + (price * haftaSonu * 1.3m);
                lblMoney.Text = string.Format("Ödenecek Tutar {0:C2}", price);
        }

        

        private void PictureBox_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (PictureBox item in grpOdalar.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    i++;
                }
            }
            if (i == nmrOda.Value)
            {
                if ((sender as PictureBox).BackColor == Color.Blue)
                    (sender as PictureBox).BackColor = Color.Green;
                else
                    MessageBox.Show("Oda seçiminiz bitmiştir.");
            }
            else
            {
                if ((sender as PictureBox).BackColor == Color.Blue)
                    (sender as PictureBox).BackColor = Color.Green;
                else
                    (sender as PictureBox).BackColor = Color.Blue;

            }
        }

        private void DtGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtCikisTarihi.MinDate = dtGirisTarihi.Value.AddDays(1.0);
        }

        private void NmrKisiSayisi_ValueChanged_1(object sender, EventArgs e)
        {
            if (nmrKisiSayisi.Value % 3 == 0)
                minNumberOfRooms = (int)nmrKisiSayisi.Value / 3;
            else
                minNumberOfRooms = ((int)nmrKisiSayisi.Value / 3) + 1;
            nmrOda.Minimum = minNumberOfRooms;
            nmrOda.Maximum = nmrKisiSayisi.Value;
        }
    }
}
