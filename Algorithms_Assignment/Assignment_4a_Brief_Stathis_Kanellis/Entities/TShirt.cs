using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;

namespace Assignment_4a_Brief_Stathis_Kanellis.Entities
{
    public class TShirt
    {
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Fabric Fabric { get; set; }

        public decimal Price { get; set; }

        public TShirt(Size size, Color color, Fabric fabric)
        {
            Size = size;
            Color = color;
            Fabric = fabric;
        }

        public void Output()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", Size, Color, Fabric);
        }
    }
}
