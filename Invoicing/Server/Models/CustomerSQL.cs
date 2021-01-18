using Invoicing.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Invoicing.Server.Models
{
    public class CustomerSQL : ICustomer, IDisposable
    {
        private SqlConnection cnct;
        public CustomerSQL(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            cnct.Dispose();
        }

        public IEnumerable<Customer> AllCustomers
            => cnct.Query<Customer>("SELECT Name, Surname FROM Customers");
    }
}
