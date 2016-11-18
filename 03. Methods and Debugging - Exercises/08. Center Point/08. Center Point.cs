using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            ClosestPoint(x1, x2, y1, y2);
        }

        private static void ClosestPoint(double x1, double x2, double y1, double y2)
        {
            var firstPointSum = Math.Abs(x1) + Math.Abs(y1);
            var secondPointSum = Math.Abs(x2) + Math.Abs(y2);
            if (firstPointSum > secondPointSum) Console.WriteLine("({0}, {1})",x2 ,y2);
            else Console.WriteLine("({0}, {1})", x1, y1);
        }
    }
}
