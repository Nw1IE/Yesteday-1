using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Admission
    {
        public static double min = 4.5;
        public static bool IsPass(Student student)
        {
            return student > min;
        }
    
       
    }
}
