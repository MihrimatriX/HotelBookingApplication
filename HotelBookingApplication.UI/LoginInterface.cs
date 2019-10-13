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
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            NewUserInterface newUserInterface = new NewUserInterface(this);
            Hide();
            newUserInterface.Show();
        }
    }
}
