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
using MyShopDataManagement.Views.Controls;
using MySqlDataAccess.Models;
using MySqlDataAccess.Views;


namespace MyShopDataManagement.Views.Forms
{
    public partial class mainForm : Form
    {
        //Use for variables
        List<Person> DataOfPerson = new List<Person>();
        AccessData dt = new AccessData();
        Person p = new Person();
        List<GetPersonData> data = new List<GetPersonData>();


        //Call OutMethod
        PersonMethods m = new PersonMethods();
        MoveControls move = new MoveControls();

        public mainForm()
        {
            InitializeComponent();
            ControlsMethods.moveSidePanel(guna2Panel1, movingCtr);
            move.MoveForm(this);

            DataOfPerson = dt.GetPeople();    
            myDataGrid.DataSource = DataOfPerson;


        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DataOfPerson = dt.SearchFirstName(searchBox.Text);
            myDataGrid.DataSource = DataOfPerson;
        }

        //




        Views.Controls.History ctrl;
        Views.Controls.CRUD crud;

        AddUserControl addCtr = new AddUserControl();

        private void myHistory_Click_1(object sender, EventArgs e)
        {
            ctrl = new History();
            addCtr.AddControl(this, ctrl, myHomePn.Left, 0) ;

        }

        private void myHome_Click(object sender, EventArgs e)
        {
            myDataGrid.DataSource = dt.GetPeople();
            myHomePn.BringToFront();
        }

        private void myCRUD_Click(object sender, EventArgs e)
        {
            AccessData ac = new AccessData();
            crud = new CRUD(ac.GetPeople());
            addCtr.AddControl(this, crud, myHomePn.Left, 0);

        }

        private void deleteDt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI");
        }

    }
}
