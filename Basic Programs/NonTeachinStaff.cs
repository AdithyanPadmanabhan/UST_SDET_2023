using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonTeachinStaff : StaffDetails
    {
        public string? Respnsibilities {  get; set; }
        public int Experience {  get; set; }


        public void DisplayNTStaffDetails ()
        {
            Console.WriteLine("Res :{0}\n Experience : {1}", Respnsibilities, Experience);
        }
}
}
