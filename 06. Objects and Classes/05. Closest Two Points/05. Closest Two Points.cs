using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            ReadAllPoints(n, points);

            double closest;
            Point first, second;

            GetClosestPoints(points, out closest, out first, out second);

            PrintResult(closest, first, second);
        }

        private static void ReadAllPoints(int n, Point[] points)
        {
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
        }

        private static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        private static void GetClosestPoints(Point[] points, out double closest, out Point first, out Point second)
        {
            closest = double.MaxValue;
            double current = 0;
            first = new Point();
            second = new Point();

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    current = GetCurrentDistance(points, i, j);

                    CheckIfCurrentDistanceIsClosest(points, ref closest, ref first, ref second, current, i, j);
                }
            }
        }

        private static double GetCurrentDistance(Point[] points, int i, int j)
        {
            double current;
            int x = Math.Abs(points[i].X - points[j].X);
            int y = Math.Abs(points[i].Y - points[j].Y);
            current = Math.Sqrt(x * x + y * y);
            return current;
        }

        private static void CheckIfCurrentDistanceIsClosest(Point[] points, ref double closest, ref Point first, ref Point second, double current, int i, int j)
        {
            if (current < closest)
            {
                closest = current;
                first = points[i];
                second = points[j];
            }
        }

        private static void PrintResult(double closest, Point first, Point second)
        {
            Console.WriteLine(closest);
            Console.WriteLine("({0}, {1})", first.X, first.Y);
            Console.WriteLine("({0}, {1})", second.X, second.Y);
        }
    }
    class Point
    {
       public int X { get; set; }
       public int Y { get; set; }
    }
}
