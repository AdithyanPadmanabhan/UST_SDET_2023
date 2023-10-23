using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custID, long accountNumber, string? name) : base(custID, accountNumber, name)
        {
        }

        public override void WelcomeMessage()// overriding
        {
            Console.WriteLine("Welcome {0}", Name);
        }
    }
}
