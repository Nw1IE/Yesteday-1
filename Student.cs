using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    {
        private string FIO;
        private double average;
        private double self;
        private string date;

        public Student(string FIO, double average, double self, string date)
        {
            this.FIO = FIO;
            this.average = average;
            this.self = self;
            this.date = date;
        }

        public static bool operator>(Student a, Student b)
        {
            if (a.average == b.average) return a.self > b.self;
            return a.average > b.average;
        }
        public static bool operator <(Student a, Student b)
        {
            if (a.average == b.average) return a.self < b.self;
            return a.average < b.average;
        }

        public static bool operator >(Student a, double min)
        {
            return a.average > min;
        }
        public static bool operator <(Student a, double min)
        {
           return a.average < min;
        }
    }
    
}
