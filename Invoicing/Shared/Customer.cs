using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Shared
{
    public class Customer
    {
        public Customer(string name, string surname) 
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; }
        public string Surname { get; }
    }
}
