using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlDataAccess.Views
{
    public class LoadControl
    {
        Form GetControl;
        public void LoadForm(Form f)
        {
            GetControl = f;
            f.Load += F_Load;
        }

        private void F_Load(object sender, EventArgs e)
        {
            if (GetControl.WindowState == FormWindowState.Normal)
            {
                GetControl.WindowState = FormWindowState.Maximized;
            }
        }

       
    }
}
