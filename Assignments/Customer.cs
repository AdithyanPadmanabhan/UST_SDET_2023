using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public Customer(int customerId, string? customerName, long phoneNumber, double balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public long PhoneNumber {  get; set; }
        public double Balance {  get; set; }



    }
}
