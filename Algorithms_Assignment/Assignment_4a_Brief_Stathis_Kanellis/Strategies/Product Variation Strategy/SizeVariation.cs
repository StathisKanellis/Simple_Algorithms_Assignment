using Assignment_4a_Brief_Stathis_Kanellis.Entities;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4a_Brief_Stathis_Kanellis.Strategies.Product_Variation_Strategy
{
    class SizeVariation : IVariationStrategy
    {
        public void Cost(TShirt shirt)
        {
            switch (shirt.Size)
            {
                case Size.XS: shirt.Price += 0.50m; break;
                case Size.S: shirt.Price += 0.75m; break;
                case Size.M: shirt.Price += 1m; break;
                case Size.L: shirt.Price += 1.25m; break;
                case Size.XL: shirt.Price += 1.50m; break;
                case Size.XXL: shirt.Price += 1.75m; break;
                case Size.XXXL: shirt.Price += 1.90m; break;
                default: shirt.Price += 0m; break;
            }
        }
    }
}
