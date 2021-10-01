using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Sql;
using System.Data;

namespace MySqlDataAccess.Models
{
    public class AccessData
    {
        //Select all properties
        public List<Person> GetPeople ()
        {
            using(IDbConnection connection =new System.Data.SqlClient.SqlConnection(GetConnectionString.ConString("ShopDB")))
            {
                var output = connection.Query<Person>("dbo.People_Select").ToList();
                return output;
            }
        }

        //Select all properties
        public List<Person> SearchFirstName(string firstName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GetConnectionString.ConString("ShopDB")))
            {
                //var output = connection.Query<Person>("select * from dbo.People where FirstName like '"+firstName+"%'", new{ FirstName =firstName}).ToList();
                var output = connection.Query<Person>("dbo.People_ListByFirstName @FirstName", new{ FirstName =firstName}).ToList();

                return output;
            }
        }
    }
}
