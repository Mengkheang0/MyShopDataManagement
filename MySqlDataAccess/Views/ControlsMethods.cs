using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MySqlDataAccess.Views
{
    public static class ControlsMethods
    {
        public static void moveSidePanel(Control baseControl,Control movingCtr)
        {
            foreach (Control item in baseControl.Controls)
            {
                if(item is Guna2Button)
                {
                    Guna2Button bt = item as Guna2Button;

                    //check if controls is button is clicked
                    bt.Click += Bt_Click;
                    void Bt_Click(object sender, EventArgs e)
                    {
                        movingCtr.Location = new Point(bt.Left - 3, bt.Location.Y);
                    }
                }
            }
        }

    
    }
}
