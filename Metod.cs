using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Metod
    {
        public static double Met(double num1, double num2)
        {
            return num1 * num2 + 0.1;
        }
        public static int Met(int num1, int num2)
        {
            return num1 * num2 + 2;
        }
        public static long Met(long num1, long num2)
        {
            return num1 * num2 + 3;
        }
        public static uint Met(uint num1, uint num2)
        {
            return num1 * num2 + 1;
        }
    }


}


