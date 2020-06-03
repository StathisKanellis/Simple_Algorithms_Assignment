using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Entities;

namespace Assignment_4a_Brief_Stathis_Kanellis.Entities
{
    class StartApp
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press:");
            Console.WriteLine("-----------------");
            Console.WriteLine("1:   -See TShirt \n2:   -Buy TShirt");
            Console.ForegroundColor = ConsoleColor.White;
            string choice = Console.ReadLine();
            bool check = false;
            switch (choice)
            {
                case "1": Storage.Print(); break;
                case "2": ClientApp.BuyTShirt(); break;
                default: Console.WriteLine("You must press 1 or 2 to continue:");
                    check = true; break;
            }
            if (check)
                Start();
        }
    }
}
