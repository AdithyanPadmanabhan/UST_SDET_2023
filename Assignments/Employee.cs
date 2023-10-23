using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayInfo
    {
        public Employee(string? firstName, string? lastName, int age, int employeeId) : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
        }

        public int EmployeeId { get; set; }

       

        public void DisplayInfo()
        {
            Console.WriteLine("Full name: {0}\n Age:{1}  ",FirstName+" "+LastName,Age);
        }
    }
}
