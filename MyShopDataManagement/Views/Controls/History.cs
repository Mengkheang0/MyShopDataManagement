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
    public partial class History : UserControl
    {
        //Use to storeOutput data
        List<string> strOutput = new List<string>();

        public History()
        {
            InitializeComponent();
        }
      
        private void deleteBt_Click(object sender, EventArgs e)
        {
            if(change)
            {
                DeleteValue(index);
            }
            else
            {
                //Item not selected yet!!
                var result = MessageBox.Show($"Please select any data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void DeleteValue(int val)
        {
            var result = MessageBox.Show($"You wanna delete '{myListBox.Items[val]}' ?","Prompt Permission",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                //Delete data
                //myListBox.Items.RemoveAt(val);
                myListBox.Items.Clear();

                //StoreData in a list
               // strOutput.Add(myListBox.Items[val].ToString());
                
                var output = DeletedData(val);
                listBox1.Items.Add(output);

            }
            else
            {
                //Restore data
                //Do nothing!!
            }
        }

        bool change;
        object obj = new object();
        int index;
        private void myListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ItemSelectedIndex = myListBox.SelectedIndex;
            change = true;

            foreach (GetPersonData dt in myListBox.SelectedItems)
            {
                Console.WriteLine(dt.MyFullProperty);
                obj = dt.MyFullProperty;
                index = myListBox.SelectedIndex;

            }
            Status(myListBox, listBox1);


        }



        // Delete Data
        public string DeletedData(int val)
        {

            return $"You been deleted '{myListBox.Items[val]}' on {DateTime.Now.ToString("d")} at {DateTime.Now.ToString("g")}";

        }
        
        //Get all listbox_SelectedItems
        public List<string> Status(ListBox listBoxItems,ListBox statusMsg)
        {
            List<string> data = new List<string>();
            ListBox.SelectedObjectCollection values = listBoxItems.SelectedItems;

            if(values.Count > 1)
            {
                foreach (GetPersonData item in values)
                {
                    data.Add(item.MyFullProperty);


                    var outPut = $"Selected  {item.MyFullProperty} ";
                    statusMsg.Items.Add(outPut);
                }
                statusMsg.Items.Add("");
                statusMsg.Items.Add($"You selected {values.Count} items");
                statusMsg.Items.Add("");

            }
            else
            {
                statusMsg.Items.Clear();
            }
           

            // set values to statusListBox

            return data;
        }

      
    }
}
