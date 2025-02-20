using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Numbres
    {
        public static int ReturnNum(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int ReturnNum(int a, int b, int c)
        {
            return Numbres.ReturnNum(Numbres.ReturnNum(a, b), c);
        }
        public static int ReturnNum(int a, int b, int c, int d)
        {
            return Numbres.ReturnNum(Numbres.ReturnNum(a, b, c), d);
        }
        public static int ReturnNum(int a, int b, int c, int d, int e)
        {
            return Numbres.ReturnNum(Numbres.ReturnNum(a, b, c, d), e);
        }
    }

   
}
