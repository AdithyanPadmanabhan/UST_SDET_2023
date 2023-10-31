using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employees
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public double PerformanceRating {  get; set; }

 

        public static double BonusCalculationOne(double perfrate)
        {
            double bonus = perfrate * 100;
            Console.WriteLine("Bonus:");
            return bonus;
        }
        public static double BonusCalculationTwo(double perfrate)
        {
            double bonus = perfrate *30* 100;
            Console.WriteLine("Bonus:");
            return bonus;
        }
    }
}
