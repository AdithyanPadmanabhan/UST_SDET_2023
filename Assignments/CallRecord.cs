using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public CallRecord(int callId, double callTime, long phoneNumber)
        {
            CallId = callId;
            CallTime = callTime;
            PhoneNumber = phoneNumber;
        }

        public int CallId { get; set; }
        public double CallTime { get; set; }
        public long PhoneNumber { get; set; }
        
       
    }
}
