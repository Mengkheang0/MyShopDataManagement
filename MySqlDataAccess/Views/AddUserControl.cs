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
    public class AddUserControl
    {
        public void AddControl(Form f,UserControl uctrl, int x,int y)
        {
            uctrl.Location = new Point(x, y);
            f.Controls.Add(uctrl);
            uctrl.BringToFront();
        }
    }
}
