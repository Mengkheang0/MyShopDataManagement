using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySqlDataAccess.Models;

namespace MyShopDataManagement.Views.Forms
{
    public partial class mainForm : Form
    {
        List<Person> DataOfPerson = new List<Person>();
        AccessData dt = new AccessData();

        public mainForm()
        {
            InitializeComponent();

            BindingData();



        }

        private void BindingData()
        {
            DataOfPerson = dt.GetPeople();
            myDataGrid.DataSource = DataOfPerson;


        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DataOfPerson = dt.SearchFirstName(searchBox.Text);
            myDataGrid.DataSource = DataOfPerson;
        }
    }
}
