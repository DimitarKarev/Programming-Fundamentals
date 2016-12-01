using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {   
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalculateDistance(p1, p2);

            Console.WriteLine(distance);

        }
        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        private static double CalculateDistance(Point p1, Point p2)
        {
            int x = Math.Abs(p1.X - p2.X);
            int y = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
