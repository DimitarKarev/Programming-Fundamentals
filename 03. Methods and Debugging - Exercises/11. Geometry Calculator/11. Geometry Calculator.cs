using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle": FindTrianglArea(); break;
                case "square": FindSquareArea(); break;
                case "rectangle": FindRectangleArea(); break;
                case "circle": FindCircleArea(); break;
                default: break;
            }
        }

        private static void FindTrianglArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = Math.Round((side * height) / 2, 2);
            Console.WriteLine("{0:f2}",area);
        }

        private static void FindSquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            var area = Math.Round(side * side,2);
            Console.WriteLine("{0:f2}", area);
        }

        private static void FindRectangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = Math.Round(width * height,2);
            Console.WriteLine("{0:f2}", area);
        }

        private static void FindCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.Round(Math.PI * radius * radius,2);
            Console.WriteLine("{0:f2}",area);
        }
    }
}
