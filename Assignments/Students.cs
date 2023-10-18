using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
        public string? studentName;
        int mark1, mark2, mark3;

        public Student(string? studentName, int mark1, int mark2, int mark3)
        {
            this.studentName = studentName;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }
        public double CalculateAverage()
        {

            double average = (mark1 + mark2 + mark3) / 3;

            return average;

        }
    }
}
