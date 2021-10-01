using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDataAccess.Models
{
    public class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public float MinimizePrice { get; set; }
        public float TotalPrice { get; set; }


        PersonMethods method = new PersonMethods();

       /* public string GetAllProperties
        {
            get
            {
                var outPut = method.FullProperties(Id, FirstName, LastName, Quantity, Date, Time, MinimizePrice, TotalPrice);

                return outPut;
            }
        }*/




    }
}
