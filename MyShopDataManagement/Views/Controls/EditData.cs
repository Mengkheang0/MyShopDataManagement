using MySqlDataAccess.Models;
using MySqlDataAccess.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShopDataManagement.Views.Controls
{
    public partial class EditData : UserControl
    {
        public EditData()
        {
            InitializeComponent();
            
        }
        List<Control> c = new List<Control>();
        DataGridView ngrid = new DataGridView();
        int Id;
        public EditData(List<string> data, DataGridView grid)
        {
            InitializeComponent();

            //AddControls(new Control[] {firstNameBox,lastNameBox,quantityBox,dateBox,minimizePriceBox,totalPriceBox }, c);
            ngrid = grid;
            Id = int.Parse(data[0]);
            firstNameBox.Text = data[1];
            lastNameBox.Text = data[2];
            quantityBox.Text = data[3];
            dateTime.Text = data[4];
            minimizePriceBox.Text = data[5];
            totalPriceBox.Text = data[6];


            


        }
        private void exitBt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if(firstNameBox.Text != "" && lastNameBox.Text!= "" && quantityBox.Text !="" && datePicker.Text!="" && minimizePriceBox.Text != "" )
            {
                AccessData dt = new AccessData();
                dt.UpdateData(Id, firstNameBox.Text, lastNameBox.Text, float.Parse(quantityBox.Text), dateTime.Text, float.Parse(minimizePriceBox.Text), float.Parse(totalPriceBox.Text));

                MessageBox.Show("Update success!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                ngrid.DataSource = dt.GetPeople();

            }
            else
            {
                MessageBox.Show("Please completes all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTime.Text = datePicker.Value.ToString("d");

        }

        private void minimizePriceBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (minimizePriceBox.TextLength > 0)
                {
                    if (int.TryParse(quantityBox.Text, out int value))
                    {
                        float val1 = float.Parse(minimizePriceBox.Text);
                        float val2 = float.Parse(quantityBox.Text);

                        float total = val1 * val2;

                        totalPriceBox.Text = total.ToString();
                    }
                }
                else
                {
                    totalPriceBox.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, quantity take only number ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void minimizePriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void quantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void quantityBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantityBox.TextLength > 0)
                {
                    if (int.TryParse(minimizePriceBox.Text, out int value))
                    {
                        float val1 = float.Parse(minimizePriceBox.Text);
                        float val2 = float.Parse(quantityBox.Text);

                        float total = val1 * val2;

                        totalPriceBox.Text = total.ToString();
                    }
                }
                else
                {
                    totalPriceBox.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, quantity take only number ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
