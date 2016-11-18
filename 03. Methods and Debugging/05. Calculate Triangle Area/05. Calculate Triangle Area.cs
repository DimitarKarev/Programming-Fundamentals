using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateArea(a, b));
        }

        private static double CalculateArea(double a, double b)
        {
            var area = (a * b) / 2;
            return area;
        }
    }
}
