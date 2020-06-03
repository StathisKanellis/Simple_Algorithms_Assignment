using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;
using Assignment_4a_Brief_Stathis_Kanellis.Strategies.Payment_Strategy;
using Assignment_4a_Brief_Stathis_Kanellis.Strategies.Product_Variation_Strategy;
using Assignment_4a_Brief_Stathis_Kanellis.Database;

namespace Assignment_4a_Brief_Stathis_Kanellis.Entities
{
    class EShop
    {
        private IPaymentStrategy paymentMethod;
        private IEnumerable<IVariationStrategy> variations;
        

        public EShop(IEnumerable<IVariationStrategy> variations)
        {
            this.variations = variations;
        }

        public void SetPaymentMethod(PaymentMethods choice)
        {
            switch (choice)
            {
                case PaymentMethods.BankTransfer:paymentMethod = new BankTransfer(); break;
                case PaymentMethods.Cash: paymentMethod = new Cash();  break;
                case PaymentMethods.CreditCart: paymentMethod = new CreditCard(); break;
                default: paymentMethod = new Cash();  break;
            }

        }

        public void PayTShirt(TShirt shirt)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine();
            foreach (var variation in this.variations)
            {
                variation.Cost(shirt);
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Globalization.CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("it-IT");
                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {shirt.Price :C2}");
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Globalization.CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("it-IT");
            Console.WriteLine($"Total Price: {shirt.Price :C2}");
            paymentMethod.Pay(shirt.Price);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
