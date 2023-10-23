using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetails
    {
        public BankDetails(int custID, long accountNumber, string? name, string? status)
        {
            CustID = custID;
            AccountNumber = accountNumber;
            Name = name;
            Status = status;
        }
        public BankDetails()
        {
            CustID = 0;
            AccountNumber = 0;
            Name = string.Empty;
            Status = "Inactive";
        }


        public BankDetails(int custID, long accountNumber, string? name)
        {
            CustID = custID;
            AccountNumber = accountNumber;
            Name = name;
            Status = "Active";
        }

        public int CustID { get; set; }
        public long AccountNumber { get; set; }
        public string? Name { get; set; }    
        public string? Status { get; set; }

        public virtual void WelcomeMessage()
        {
            Console.WriteLine("welocome");
        }

        public static void ExitMessge()
        {
            Console.Write("Done");
        }


        public void GetAccountDetails(int custID)
        {
            if (CustID == custID)
                Console.WriteLine("AccNo:{0} \t Name: {1} \t Status:{2}", AccountNumber, Name, Status);
            else Console.WriteLine("Cust id doesnt exit");

        }

        public void GetAccountDetails(long accountNumber)
        {
            if (AccountNumber == accountNumber)
                Console.WriteLine("CustID:{0} \t Name: {1} \t Status:{2}", CustID, Name, Status);
            else Console.WriteLine("Account number doesnt exit");

        }
        public void GetAccountDetails(string? name)
        {
            if (Name == name)
                Console.WriteLine("CustID:{0} \t Accnum: {1} \t Status:{2}", CustID, AccountNumber, Status);
            else Console.WriteLine("Name  doesnt exit");

        }

    }
}
