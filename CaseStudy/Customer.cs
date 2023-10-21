using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        public Customer(string? name, double contactDetails, int customerID)
        {
            Name = name;
            ContactDetails = contactDetails;
            CustomerID = customerID;
        }

        public string? Name { get; set; }
        public double ContactDetails { get; set; }
        public int CustomerID {  get; set; }

        public void DisplayCustomer()
        {
            Console.WriteLine("Customer Name:{0} \n Contact Details:{1}\n CustomerId : {2}",Name,ContactDetails,CustomerID);
        }

    }
}
