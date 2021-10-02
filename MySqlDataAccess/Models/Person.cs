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
        public float MinimizePrice { get; set; }
        public float TotalPrice { get; set; }



        public List<GetPersonData> Copy(List<Person> people)
        {

            List<GetPersonData> nlist = new List<GetPersonData>();

            foreach (Person item in people)
            {
                //return 1 table row and added to listOfIt
                var Output = item.Data(item.Id, item.FirstName, item.LastName, item.Quantity, item.Date, item.MinimizePrice, item.TotalPrice);
                nlist.Add(Output);
            }

            return nlist;
        }

        private GetPersonData Data(int id,string firstName,string lastName, int quantity, string date, float minimizePrice,float totalPrice)
        {
            var outPut = new GetPersonData(id, firstName, lastName, quantity, date, minimizePrice, totalPrice);

            return outPut;
        }
       




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
