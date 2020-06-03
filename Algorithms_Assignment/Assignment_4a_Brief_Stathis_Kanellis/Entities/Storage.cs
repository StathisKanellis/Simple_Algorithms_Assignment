using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Database;
using Assignment_4a_Brief_Stathis_Kanellis.Sorting_Algorithms;

namespace Assignment_4a_Brief_Stathis_Kanellis.Entities
{
    class Storage
    {
        public static void Print()
        {
            //-------------- ALL Synthetic Data -----------------------
            MyDatabase db = new MyDatabase();
            PrintAllItems(db.Shirts);

            //========================= QUICK SORT =========================
            
            //-------------- ALL Synthetic Data Size ASC
            QuickShort.SizeAsc(db.Shirts, 0, db.Shirts.Count() - 1);
            PrintAllItems(db.Shirts);
            
            //-------------- ALL Synthetic Data Size DESC
            QuickShort.SizeDesc(db.Shirts, 0, db.Shirts.Count() - 1);
            PrintAllItems(db.Shirts);

            //========================= BUCKET SORT =========================
            
            //-------------- ALL Synthetic Data Color ASC
            BucketSort.ColorAsc(db.Shirts);
            PrintAllItems(db.Shirts);
            
            //-------------- ALL Synthetic Data Color DESC
            BucketSort.ColorDesc(db.Shirts);
            PrintAllItems(db.Shirts);

            //========================= BUBBLE SORT =========================

            //-------------- ALL Synthetic Data Fabric ASC
            //BubbleSort.FabricAsc(db.Shirts);
            //PrintAllItems(db.Shirts);

            //-------------- ALL Synthetic Data Fabric DESC
            //BubbleSort.FabricDesc(db.Shirts);
            //PrintAllItems(db.Shirts);

            //-------------- ALL Synthetic Data Fabric ASC and DESC with Delegate
            // creating object of class with name bubble
            BubbleSort bubble = new BubbleSort();
            // creating delegate object, name as "bubbleDele" and pass the 1st method "FabricAsc" 
            //as parameter by class object "bubble" 
            BubbleSort.bubbleSortDelegate bubbleDele = bubble.FabricAsc;

            // call 2nd method "FabricDesc" Multicasting 
            bubbleDele += bubble.FabricDesc;
            // pass the values in two method by using "Invoke" method
            bubbleDele.Invoke(db.Shirts);

            PrintAllItems(db.Shirts);



            //-------------- ALL Synthetic Data Size and Color and Fabric ASC
            BubbleSort.SizeColorFabricAsc(db.Shirts);
            PrintAllItems(db.Shirts);
            //-------------- ALL Synthetic Data Size and Color and Fabric DESC
            BubbleSort.SizeColorFabricDesc(db.Shirts);
            PrintAllItems(db.Shirts);

        }

        public static void PrintAllItems(IEnumerable<TShirt> Shirts)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~~~~~~~~~~~~~ All Clothes ~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Size", "Color", "Fabric");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Shirts)
            {
                item.Output();
            }
        }
    }
}
