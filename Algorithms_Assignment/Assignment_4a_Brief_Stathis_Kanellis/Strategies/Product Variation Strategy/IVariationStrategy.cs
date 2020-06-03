using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Entities;

namespace Assignment_4a_Brief_Stathis_Kanellis.Strategies.Product_Variation_Strategy
{
    interface IVariationStrategy
    {
        void Cost(TShirt shirt);
    }
}
