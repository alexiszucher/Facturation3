using System;
using System.Collections.Generic;
using System.Linq;

namespace Invoicing.Shared
{
    public class BusinessTestData : IBusinessData
    {
        private Invoice[] testInvoices =
        {
        };

        public BusinessTestData()
        {
            testInvoices[1].RegisterPayment(DateTime.Now, 12154.6m);
            testInvoices[3].RegisterPayment(DateTime.Now, 16077.26m);
            testInvoices[3].Expected = DateTime.Now;
        }
        
        public IEnumerable<Invoice> AllInvoices => testInvoices;

        public decimal SalesRevenue => testInvoices.Sum(invoice => invoice.Amount);

        public decimal Outstanding => testInvoices.Sum(invoice => invoice.Amount - invoice.Paid);
    }
}
