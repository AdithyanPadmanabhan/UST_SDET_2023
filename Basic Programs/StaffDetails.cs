using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StaffDetails
    {
        public int StaffId { get; set; }
        public string? Name { get; set; }
        public string? Depat { get; set; }


        public void DisplayStaffDetails()
        {

            Console.WriteLine("Staff id:{0} \n Staff Name:{1} \n  Department {2 }",StaffId, Name, Depat);
        }

    }
}
