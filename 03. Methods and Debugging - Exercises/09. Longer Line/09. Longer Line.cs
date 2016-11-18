using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());
            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4) == "FirstLine") FindCloserPoint(x1, y1, x2, y2);
            else FindCloserPoint(x3, y3, x4, y4);
        }

        private static void FindCloserPoint(double x1, double y1, double x2, double y2)
        {
            var firstPointSum = Math.Abs(x1) + Math.Abs(y1);
            var secondPointSum = Math.Abs(x2) + Math.Abs(y2);
            if (firstPointSum > secondPointSum) Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            else Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2 ,y2);
        }

        private static string FindLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            var length1 = x1 - x2;
            var width1 = y1 - y2;
            var length2 = x3 - x4;
            var width2 = y3 - y4;
            var firstLine = Math.Sqrt(length1 * length1 + width1 * width1);
            var secondLine = Math.Sqrt(length2 * length2 + width2 * width2);
            if (firstLine < secondLine) return "SecondLine";
            else return "FirstLine";
        }
    }
}
