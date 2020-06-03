using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_4a_Brief_Stathis_Kanellis.Entities;
using Assignment_4a_Brief_Stathis_Kanellis.Enumeration;

namespace Assignment_4a_Brief_Stathis_Kanellis.Database
{
    class MyDatabase
    {
        public List<TShirt> Shirts { get; set; }

        public MyDatabase()
        {
            TShirt s1 = new TShirt(Size.L, Color.GREEN, Fabric.CASHMERE);
            TShirt s2 = new TShirt(Size.M, Color.BLUE, Fabric.COTTON);
            TShirt s3 = new TShirt(Size.S, Color.RED, Fabric.LINEN);
            TShirt s4 = new TShirt(Size.M, Color.BLUE, Fabric.POLYESTER);
            TShirt s5 = new TShirt(Size.XS, Color.GREEN, Fabric.COTTON);
            TShirt s6 = new TShirt(Size.M, Color.BLUE, Fabric.CASHMERE);
            TShirt s7 = new TShirt(Size.L, Color.GREEN, Fabric.COTTON);
            TShirt s8 = new TShirt(Size.S, Color.BLUE, Fabric.LINEN);
            TShirt s9 = new TShirt(Size.M, Color.BLUE, Fabric.CASHMERE);
            TShirt s10 = new TShirt(Size.L, Color.RED, Fabric.COTTON);
            TShirt s11 = new TShirt(Size.M, Color.RED, Fabric.CASHMERE);
            TShirt s12 = new TShirt(Size.L, Color.BLUE, Fabric.CASHMERE);
            TShirt s13 = new TShirt(Size.L, Color.INDIGO, Fabric.COTTON);
            TShirt s14 = new TShirt(Size.S, Color.RED, Fabric.LINEN);
            TShirt s15 = new TShirt(Size.S, Color.BLUE, Fabric.COTTON);
            TShirt s16 = new TShirt(Size.M, Color.BLUE, Fabric.CASHMERE);
            TShirt s17 = new TShirt(Size.XS, Color.RED, Fabric.LINEN);
            TShirt s18 = new TShirt(Size.XS, Color.BLUE, Fabric.POLYESTER);
            TShirt s19 = new TShirt(Size.L, Color.RED, Fabric.POLYESTER);
            TShirt s20 = new TShirt(Size.L, Color.BLUE, Fabric.CASHMERE);
            TShirt s21 = new TShirt(Size.L, Color.GREEN, Fabric.CASHMERE);
            TShirt s22 = new TShirt(Size.M, Color.BLUE, Fabric.COTTON);
            TShirt s23 = new TShirt(Size.S, Color.RED, Fabric.LINEN);
            TShirt s24 = new TShirt(Size.M, Color.BLUE, Fabric.POLYESTER);
            TShirt s25 = new TShirt(Size.XS, Color.GREEN, Fabric.COTTON);
            TShirt s26 = new TShirt(Size.M, Color.BLUE, Fabric.CASHMERE);
            TShirt s27 = new TShirt(Size.L, Color.GREEN, Fabric.COTTON);
            TShirt s28 = new TShirt(Size.S, Color.BLUE, Fabric.LINEN);
            TShirt s29 = new TShirt(Size.M, Color.BLUE, Fabric.CASHMERE);
            TShirt s30 = new TShirt(Size.L, Color.RED, Fabric.COTTON);
            TShirt s31 = new TShirt(Size.M, Color.RED, Fabric.CASHMERE);
            TShirt s32 = new TShirt(Size.L, Color.BLUE, Fabric.CASHMERE);
            TShirt s33 = new TShirt(Size.L, Color.INDIGO, Fabric.COTTON);
            TShirt s34 = new TShirt(Size.S, Color.RED, Fabric.LINEN);
            TShirt s35 = new TShirt(Size.S, Color.BLUE, Fabric.COTTON);
            TShirt s36 = new TShirt(Size.M, Color.BLUE, Fabric.CASHMERE);
            TShirt s37 = new TShirt(Size.XS, Color.RED, Fabric.LINEN);
            TShirt s38 = new TShirt(Size.XS, Color.BLUE, Fabric.POLYESTER);
            TShirt s39 = new TShirt(Size.L, Color.RED, Fabric.POLYESTER);
            TShirt s40 = new TShirt(Size.L, Color.BLUE, Fabric.CASHMERE);

            Shirts = new List<TShirt>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12,
                s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27,
                s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38, s39, s40};
        }
    }
}
