using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Doctor : IDoctor,IAppoinment
    {
        public int Did { get; set; }
        public string? DoctorName { get; set; }

        public void AddNewDoctor(int did,string? dname)
        {
            Did = did; DoctorName = dname;
        }

        public void ModifyDoctor(int did, string? dname)
        {
            Did = did; DoctorName = dname;
        }
        public void DisplayDoctorDetails() {
        
        Console.WriteLine("DoctorID: {0}\n DoctorName : {1}",Did,DoctorName);
                }

        public void BookApp(int did, string pname)
        {
            Console.WriteLine("Booked app for {0} with Doctor {1}",pname,Did);
        }

        public void DelApp(string pname)
        {
            Console.WriteLine("Cancel app for {0} ", pname);
        }
    }
}
