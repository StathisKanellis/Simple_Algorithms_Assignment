using Assignment_4a_Brief_Stathis_Kanellis.Entities;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4a_Brief_Stathis_Kanellis.Strategies.Product_Variation_Strategy
{
    class ColorVariation : IVariationStrategy
    {
        public void Cost(TShirt shirt)
        {
            switch (shirt.Color)
            {
                case Color.BLUE: shirt.Price += 0.50m; break;
                case Color.GREEN: shirt.Price += 0.75m; break;
                case Color.INDIGO: shirt.Price += 1m; break;
                case Color.ORANGE: shirt.Price += 1.25m; break;
                case Color.RED: shirt.Price += 1.50m; break;
                case Color.YELLOW: shirt.Price += 1.75m; break;
                case Color.VIOLET: shirt.Price += 1.90m; break;
                default: shirt.Price += 0m; break;
            }
        }
    }
}
