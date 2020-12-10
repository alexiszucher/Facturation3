﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Invoicing.Shared
{
    public class BusinessTestData : IBusinessData
    {
        private Invoice[] testInvoices =
        {
            new Invoice("B2345", "FOO", 2154.6m     , DateTime.Now),
            new Invoice("B1345", "BAR", 12154.6m    , DateTime.Now),
            new Invoice("R2145", "BAR", 254.6m      , DateTime.Now),
            new Invoice("T2145", "BOO", 32154.52m   , DateTime.Now)
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
