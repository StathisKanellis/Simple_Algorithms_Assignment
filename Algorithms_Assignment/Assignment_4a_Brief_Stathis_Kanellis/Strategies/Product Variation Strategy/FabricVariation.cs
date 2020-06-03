using Assignment_4a_Brief_Stathis_Kanellis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;

namespace Assignment_4a_Brief_Stathis_Kanellis.Strategies.Product_Variation_Strategy
{
    class FabricVariation : IVariationStrategy
    {
        public void Cost(TShirt shirt)
        {
            switch (shirt.Fabric)
            {
                case Fabric.CASHMERE: shirt.Price += 0.50m; break;
                case Fabric.COTTON: shirt.Price += 0.75m; break;
                case Fabric.LINEN: shirt.Price += 1m; break;
                case Fabric.POLYESTER: shirt.Price += 1.25m; break;
                case Fabric.RAYON: shirt.Price += 1.50m; break;
                case Fabric.SILK: shirt.Price += 1.75m; break;
                case Fabric.WOOL: shirt.Price += 1.90m; break;
                default: shirt.Price += 0; break;
            }
        }
    }
}
