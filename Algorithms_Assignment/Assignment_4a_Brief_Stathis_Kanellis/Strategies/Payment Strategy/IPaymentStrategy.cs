using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4a_Brief_Stathis_Kanellis.Strategies.Payment_Strategy
{
    interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
