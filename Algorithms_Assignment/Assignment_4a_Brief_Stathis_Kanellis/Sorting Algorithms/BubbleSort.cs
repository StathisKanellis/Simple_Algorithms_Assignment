using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Entities;

namespace Assignment_4a_Brief_Stathis_Kanellis.Sorting_Algorithms
{
    class BubbleSort
    {
        public delegate List<TShirt> bubbleSortDelegate(List<TShirt> tshirts);


        public List<TShirt> FabricAsc(List<TShirt> tshirts)
        {
            for (int i = 0; i < tshirts.Count() - 1; i++)
                for (int j = 0; j < tshirts.Count() - i - 1; j++)
                    if (tshirts[j].Fabric > tshirts[j + 1].Fabric)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
            return tshirts;
        }

        public static List<TShirt> SizeColorFabricAsc(List<TShirt> tshirts)
        {
            for (int i = 0; i < tshirts.Count() - 1; i++)
            {
                for (int j = 0; j < tshirts.Count() - i - 1; j++)
                {
                    if (tshirts[j].Fabric > tshirts[j + 1].Fabric)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    if (tshirts[j].Color > tshirts[j + 1].Color)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    if (tshirts[j].Size > tshirts[j + 1].Size)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
            }
            return tshirts;
        }


        public List<TShirt> FabricDesc(List<TShirt> tshirts)
        {
            for (int i = 0; i < tshirts.Count() - 1; i++)
                for (int j = 0; j < tshirts.Count() - i - 1; j++)
                    if (tshirts[j].Fabric < tshirts[j + 1].Fabric)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
            return tshirts;
        }

        public static List<TShirt> SizeColorFabricDesc(List<TShirt> tshirts)
        {
            for (int i = 0; i < tshirts.Count() - 1; i++)
            {
                for (int j = 0; j < tshirts.Count() - i - 1; j++)
                {
                    if (tshirts[j].Fabric < tshirts[j + 1].Fabric)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    if (tshirts[j].Color < tshirts[j + 1].Color)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                    if (tshirts[j].Size < tshirts[j + 1].Size)
                    {
                        TShirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                    }
                }
            }
            return tshirts;
        }
    }
}
