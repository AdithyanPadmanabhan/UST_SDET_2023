using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    class Electricity
    {
        public int consumerNumber, previousReading, currentReading;
        public string? consumerName;
        /*  public  Electricity() {
            consumerName = "Amal";
                consumerNumber = 12345;
                previousReading =9000;    
                currentReading = 9200;

            }*/


        public Electricity(int consumerNumber, int previousReading, int currentReading, string? consumerName)

        {
            this.consumerNumber = consumerNumber;
            this.previousReading = previousReading;
            this.currentReading = currentReading;
            this.consumerName = consumerName;
        }

        public double CalculateBill()

        {
            double billamount;
            int reading = currentReading - previousReading;
            if (reading <= 100)
            {
                billamount = reading * 2.00;

            }
            else if (reading <= 201 && reading >= 101)
            {
                billamount = (100 * 2) + ((reading - 100) * 2.5);
            }
            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }

            else
            {

                billamount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 3.5);

            }
            return billamount;
        }

    }
}
