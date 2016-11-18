using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            double diff =Math.Abs(b - a);
            if (diff >= 0.000001) Console.WriteLine("False");
            else Console.WriteLine("True");
        }
    }
}
