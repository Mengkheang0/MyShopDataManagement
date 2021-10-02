using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDataAccess.Models
{
    public class PersonMethods 
    {
        public string FullProperties(int id, string firstName,string lastName,int Quantity,string date,string time,float minimizePrice,float totalPrice)
        {
            var Output = $"{id}. {firstName}_{lastName}  {Quantity}items   {date}   {time}PM   {minimizePrice}$   {totalPrice}$";

            return Output;
        }

        public List<GetPersonData> GetPeopleData(Person person,List<Person> listPeople)
        {
            List<GetPersonData> data = new List<GetPersonData>();
            data = person.Copy(listPeople);
            return data;
        }


    }
}
