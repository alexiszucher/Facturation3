using Invoicing.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Invoicing.Server.Models
{
    public class BusinessDataSQL : IBusinessData, IDisposable
    {
        private SqlConnection cnct;
        public BusinessDataSQL(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            cnct.Dispose();
        }

        public IEnumerable<Invoice> AllInvoices
            => cnct.Query<Invoice>("SELECT Reference,Customer,Amount,Created,Paid FROM Invoices ORDER BY Expected DESC");

        public decimal SalesRevenue
            => cnct.QuerySingle<decimal>("SELECT SUM(Amount) FROM Invoices");

        public decimal Outstanding
            => cnct.QuerySingle<decimal>("SELECT SUM(Amount-Paid) FROM Invoices");

    }
}
