using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Surgeon : Doctor
    {
        public int Sid { get; set; }

        public string? SName { get; set; }

        public void DisplaySurgeon()
        {
            Console.WriteLine("SurgeonID : {0} /n SurgeonName: {1}", Sid, SName);

        }
    }
}
