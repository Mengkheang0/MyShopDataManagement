using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDataAccess.Models
{
    public class GetPersonData
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
        public float MinimizePrice { get; set; }
        public float TotalPrice { get; set; }

        public GetPersonData(int id,string firstName,string lastName,int quantity,string date,float minimizePrice,float totalPrice) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Quantity = quantity;
            Date = date;
            MinimizePrice = minimizePrice;
            TotalPrice = totalPrice;
        }


        public string MyFullProperty 
        {
            get
            {
                return $"{Id}. {FirstName} {LastName}  {Quantity}  {Date}  {MinimizePrice}$ {TotalPrice}$";
            }
           
        }



    }
}
