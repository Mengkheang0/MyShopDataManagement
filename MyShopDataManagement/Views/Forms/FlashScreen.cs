using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShopDataManagement.Views.Forms
{
    public partial class FlashScreen : Form
    {
        public FlashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 10;
            if(guna2ProgressBar1.Value >= 100)
            {
                Thread th = new Thread(nForm);
                th.ApartmentState = ApartmentState.STA;
                th.Start();

                void nForm()
                {
                    Application.Run(new Views.Forms.mainForm());
                }
                this.Close();
                timer1.Stop();
            }
        }

        
    }
}
