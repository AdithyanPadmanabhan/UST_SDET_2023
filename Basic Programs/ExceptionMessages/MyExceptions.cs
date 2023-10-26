using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {

        public static List<string> excepMeassagelist = new List<string>()
       {


            "Dont give zero for denomintor",
            "Index is out of range",
            "Unknown Exception"

        };
        public static Dictionary<int, string> excepMeassage = new Dictionary<int, string>()
       {


            {1,"Dont give zero for denomintor" },
            {2, "Index is out of range" },
            {3, "Unknown Exception" },
            {4,"Age is less" },
            {5,"Age is More" }

        };
    }

    internal class Number1Exception : Exception
    {
        public Number1Exception(string message) : base(message)
        {


        }
    }
    internal class Number2Exception : Exception
    {
        public Number2Exception(string message) : base(message)
        {


        }
    }
}
