using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Entities;

namespace Assignment_4a_Brief_Stathis_Kanellis.Sorting_Algorithms
{
    class BucketSort
    {
        public static void ColorAsc(List<TShirt> shirts)
        {
            var minValue = shirts[0].Color;
            var maxValue = shirts[0].Color;
            for (int i = 1; i < shirts.Count; i++)
            {
                if (shirts[i].Color > maxValue)
                    maxValue = shirts[i].Color;
                if (shirts[i].Color < minValue)
                    minValue = shirts[i].Color;
            }
            List<TShirt>[] bucket = new List<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<TShirt>();
            }

            for (int i = 0; i < shirts.Count; i++)
            {
                bucket[shirts[i].Color - minValue].Add(shirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        shirts[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }


        public static void ColorDesc(List<TShirt> shirts)
        {
            var minValue = shirts[0].Color;
            var maxValue = shirts[0].Color;
            for (int i = 1; i < shirts.Count; i++)
            {
                if (shirts[i].Color > maxValue)
                    maxValue = shirts[i].Color;
                if (shirts[i].Color < minValue)
                    minValue = shirts[i].Color;
            }
            List<TShirt>[] bucket = new List<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<TShirt>();
            }

            for (int i = 0; i < shirts.Count; i++)
            {
                bucket[shirts[i].Color - minValue].Add(shirts[i]);
            }

            int k = shirts.Count - 1;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        shirts[k] = bucket[i][j];
                        k--;
                    }
                }
            }
        }
    }
}
