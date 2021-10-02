using MySqlDataAccess.Models;
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
using MySqlDataAccess.Views;
using System.Threading;

namespace MyShopDataManagement.Views.Controls
{
    public partial class CRUD : UserControl
    {
        public CRUD()
        {
            InitializeComponent();
        }
        public CRUD(List<Person> people)
        {
            InitializeComponent();
            myDataGrid.DataSource = people;
            getPeople = people;

            values();
        }

        void values()
        {
            foreach (DataGridViewCell item in myDataGrid.CurrentRow.Cells)
            {
                list.Add(item.Value.ToString());
            }
        }

        //Get List of rows when clicked
        List<Person> getPeople = new List<Person>();
        Person FullRowValues = new Person();
        List<string> list = new List<string>();
        //List<Guna2TextBox> lsBox = new List<Guna2TextBox>();
        



        private void myDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(list.Count == 7)
            {
                list.Clear();
            }

            foreach (DataGridViewCell item in myDataGrid.CurrentRow.Cells)
            { 
                list.Add(item.Value.ToString());
            }


        }
        public void AssignData(List<Guna2TextBox> ls,List<string> lsString)
        {
            for (int i = 0; i < lsString.Count; i++)
            {
                ls[i].Text = lsString[i];
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            values();
            EditData dt = new EditData(list,myDataGrid);

            this.Controls.Add(dt);
            dt.BringToFront();


            //Refresh data
            AccessData ac = new AccessData();
            myDataGrid.DataSource = ac.GetPeople();
            list.Clear();

        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            if(myDataGrid.SelectedRows != null)
            {
                values();

                AccessData dt = new AccessData();
                string value = myDataGrid.CurrentRow.Cells[0].Value.ToString();

                var x = MessageBox.Show($"You wanna delete ({list[0]}. {list[1]} {list[2]} {list[3]} {list[4]} {list[5]} {list[6]}) ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                //var x = MessageBox.Show($"You wanna delete this data ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if(x == DialogResult.Yes)
                {
                    dt.DeleteData(int.Parse(list[0]));

                }

                //Refresh data
                myDataGrid.DataSource = dt.GetPeople();
            }
            else
            {
                MessageBox.Show("Please select any data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            addData dt = new addData(list,myDataGrid);

            this.Controls.Add(dt);
            dt.BringToFront();

            //Refresh data
            AccessData ac = new AccessData();
            myDataGrid.DataSource = ac.GetPeople();
            list.Clear();


        }
    }
}
