﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment_4a_Brief_Stathis_Kanellis.Strategies.Payment_Strategy
{
    public class BankTransfer : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Globalization.CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("it-IT");
            Console.WriteLine($"Paying {amount :C2} using Bank Transfer it's succeful ");
        }
    }
}
