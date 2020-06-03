using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Entities;

namespace Assignment_4a_Brief_Stathis_Kanellis.Sorting_Algorithms
{
    class QuickShort
    {

        public static void SizeAsc(List<TShirt> shirt, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionAsc(shirt, low, high);
                SizeAsc(shirt, low, pi - 1);
                SizeAsc(shirt, pi + 1, high);
            }
        }

        static int partitionAsc(List<TShirt> shirts, int low, int high)
        {
            TShirt pivot = shirts[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (shirts[j].Size < pivot.Size)
                {
                    i++;
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }
            var temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;
            return i + 1;
        }

        public static void SizeDesc(List<TShirt> shirt, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionDesc(shirt, low, high);
                SizeDesc(shirt, low, pi - 1);
                SizeDesc(shirt, pi + 1, high);
            }
        }

        static int partitionDesc(List<TShirt> shirts, int low, int high)
        {
            TShirt pivot = shirts[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (shirts[j].Size > pivot.Size)
                {
                    i++;
                    TShirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }
            TShirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;
            return i + 1;
        }

    }
}
