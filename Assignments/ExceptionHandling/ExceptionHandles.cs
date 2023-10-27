using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionHandling
{
    internal class ExceptionHandles
    {
        public static Dictionary<int, string> excepMeassage = new Dictionary<int, string>()
       {


            {1,"Patient name and daignosis should not be empty or  null" },
            {2, "Treatment cost should be positive" }
           

        };

    }
    internal class InvalidMedicalRecordException : Exception
    {
        public InvalidMedicalRecordException(string message) : base(message)
        {

        }

    }
    internal class InvalidPatientDataException: Exception 
    {
        public InvalidPatientDataException(string message) : base(message)
        {
             
        }
    }
}
