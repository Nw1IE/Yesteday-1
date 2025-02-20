using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Deposit
    {
        private  string FIO;
        private static double Sum;
        private static double Percent = 20;

       /* public Deposit(string FIO, double Sum, double Percent)
        {
            this.FIO = FIO;
            this.Sum = Sum;
        }*/
        public static double PercentSum(double Sum)
        {
            return Sum++;
            
        }

        public static Deposit operator ++(Deposit obj)
        {
            obj = Sum + (Percent * Sum) / 100;
            return obj;
        }
        public static Deposit operator --(double obj)
        {
            obj = Sum - (Percent * Sum) / 100;
            return obj;
        }

    
    }
}
