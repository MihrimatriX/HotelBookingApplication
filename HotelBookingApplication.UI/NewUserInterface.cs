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
            this.Close();

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
            else if (txtTcNo.Text.Length != 11)
                MessageBox.Show("TC kimlik numarasını 11 haneli olarak giriniz.");
            else
            {
                if (Connection.IsUserNameAvailable(txtUserName.Text))
                {
                    if (Connection.CustomerSearch(txtTcNo.Text) == -1)
                    {
                        Connection.AddCustomer(txtFirstName.Text, txtLastName.Text, txtTcNo.Text);
                        Connection.AddAppUser(Connection.CustomerSearch(txtTcNo.Text)/*CustomerID*/, txtUserName.Text, txtPassword.Text);
                        MessageBox.Show("Kullanıcı eklendi.");
                        this.Close();
                    }
                    else
                    {
                        if (Connection.IsAppUser(Connection.CustomerSearch(txtTcNo.Text)))
                            MessageBox.Show("Bu TC No'ya ait kullanıcı bulunmaktadır.");
                        else
                        {
                            Connection.AddAppUser(Connection.CustomerSearch(txtTcNo.Text), txtUserName.Text, txtPassword.Text);
                            MessageBox.Show("Kullanıcı eklendi.");
                            this.Close();
                        }

                    }
                }
                else
                    MessageBox.Show("Bu kulanıcı adı daha önce alınmıştır. Lütfen farklı bir kullanıcı adı giriniz.");
            }
        }

        private void TxtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void NewUserInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginInterface.Show();
        }
    }
}
