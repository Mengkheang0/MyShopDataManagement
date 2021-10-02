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
    public partial class addData : UserControl
    {
        public addData()
        {
            InitializeComponent();
        }

        DataGridView ngrid = new DataGridView();
        public addData(List<string> data,DataGridView grid)
        {
            InitializeComponent();
            ngrid = grid;
            dateTime.Text = datePicker.Value.ToString("d");



        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            if(firstNameBox.Text != "" && lastNameBox.Text != "" && quantityBox.Text != "" && dateTime.Text != "" && minimizePriceBox.Text != "" && totalPriceBox.Text != "")
            {
                AccessData dt = new AccessData();
                dt.AddData(firstNameBox.Text, lastNameBox.Text, float.Parse(quantityBox.Text), dateTime.Text, float.Parse(minimizePriceBox.Text), float.Parse(totalPriceBox.Text));

                MessageBox.Show("Added success!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ngrid.DataSource = dt.GetPeople();

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please completes all field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void minimizePriceBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if(minimizePriceBox.TextLength > 0)
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

        private void quantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTime.Text = datePicker.Value.ToString("d");
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

        private void quantityBox_TextChanged(object sender, EventArgs e)
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
    }
}
