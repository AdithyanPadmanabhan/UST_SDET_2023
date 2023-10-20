using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {

        public string? CollegeName { get; set; }
        public string? CollegeType { get; set; }
        public int CollegeId {  get; set; }

        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name:{0}\n College Type: {1}\n CollegeID: {2}", CollegeName,
                CollegeType, CollegeId);
        }


    }
}
