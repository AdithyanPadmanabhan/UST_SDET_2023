﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IOrderable
    {
        void PlacingOrder();
        void ProcessingPayment();
        void DeliveringProduct();

    }
}
