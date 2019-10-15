using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingApplication.DATA
{
    public class Metotlar
    {
        public static bool BosAlanVarMi(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "") return true;
                }
                else if (item is ComboBox)
                {
                    if ((item as ComboBox).SelectedIndex == -1) return true;
                }
            }
            return false;
        }

        public static void Temizle(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
            }
        }
    }
}
