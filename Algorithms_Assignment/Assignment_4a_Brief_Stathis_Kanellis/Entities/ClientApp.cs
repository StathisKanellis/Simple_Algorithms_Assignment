using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Strategies.Product_Variation_Strategy;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;

namespace Assignment_4a_Brief_Stathis_Kanellis.Entities
{
    class ClientApp
    {
        public static void BuyTShirt()
        {
            List<IVariationStrategy> variations = new List<IVariationStrategy>()
            {
                new SizeVariation(),
                new ColorVariation(),
                new FabricVariation()
            };

            Size size = ChooseSize();
            Color color = ChooseColor();
            Fabric fabric = ChooseFabric();

            TShirt shirt = new TShirt(size, color, fabric);
            EShop eshop = new EShop(variations);

            PaymentMethods paymentMethod = ChoosePaymentMethod();

            eshop.SetPaymentMethod(paymentMethod);
            eshop.PayTShirt(shirt);



        }

        private static Size ChooseSize()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose Size");
            Console.WriteLine("-----------");
            var sizes = Enum.GetValues(typeof(Size));
            int counter = 0;
            foreach (var size in sizes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}     -{1}", ++counter, size);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return (Size)Convert.ToInt32(Console.ReadLine());
        }

        private static Color ChooseColor()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose Color");
            Console.WriteLine("------------");
            var colors = Enum.GetValues(typeof(Color));
            int counter = 0;
            foreach (var color in colors)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}    -{1}", ++counter, color);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return (Color)Convert.ToInt32(Console.ReadLine());
        }

        private static Fabric ChooseFabric()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose Fabric");
            Console.WriteLine("-------------");
            var fabrics = Enum.GetValues(typeof(Fabric));
            int counter = 0;
            foreach (var fabric in fabrics)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}  -{1}", ++counter, fabric);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return (Fabric)Convert.ToInt32(Console.ReadLine());
        }

        private static PaymentMethods ChoosePaymentMethod()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose Payment:");
            var payments = Enum.GetValues(typeof(PaymentMethods));
            int counter = 0;
            foreach (var payment in payments)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}     -{1}", ++counter, payment);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return (PaymentMethods)Convert.ToInt32(Console.ReadLine());
        }
    }
}
