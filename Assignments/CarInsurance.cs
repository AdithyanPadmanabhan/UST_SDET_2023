using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicys
    {


        public CarInsurance(string? policyName, int policyId, double premiumAmount, string? type) : base(policyName, policyId, premiumAmount)
        {
            Type = type;
        }

        public string? Type { get; set; }
        public override double CalculatePremium()
        {
            if (Type == "Heavy")
            {
                return PremiumAmount += PremiumAmount * 1.5;
            }
            else if (Type == "Light")
            {
                return PremiumAmount += PremiumAmount * 2.5;
            }
            else
            {
                return PremiumAmount += PremiumAmount * 3.5;
            }
        }
    }
}
