using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancePolicys
    {
        public LifeInsurance(string? policyName, int policyId, double premiumAmount, int age) : base(policyName, policyId, premiumAmount)
        {
            Age = age;

        }
        public int Age { get; set; }

       

        public override double CalculatePremium()
        {
           if(Age >= 30 && Age<=40) {
                return PremiumAmount += PremiumAmount * 2.5;
            }
           else if(Age>=41 && Age <= 50)
            {
                return PremiumAmount += PremiumAmount * 3.5;

            }
           else { return PremiumAmount+=PremiumAmount* 4.5; }
        }
    }
}
