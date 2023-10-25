using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName { get; set; }
        public int PolicyId { get; set; }
        public double PremiumAmount {  get; set; }

        public void RenewPolicy(double newPremium)
        {
            PremiumAmount = newPremium;
            Console.WriteLine("updated premium Amount:" + PremiumAmount);
        }
        public void RenewPolicy()
        {
            double increaseAmount = PremiumAmount * .10;
            PremiumAmount += increaseAmount;
            Console.WriteLine("Increased PremiumAmount :" + PremiumAmount);
        }

        public void Display()
        {
            Console.WriteLine("PolicyID: {0} PolicyName: {1}  premiumAmount:{2}", PolicyId, PolicyName, PremiumAmount);
        }



    }
}
