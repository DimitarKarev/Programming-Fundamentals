using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle firstCircle = GetFirstCircle(firstCircleParams);
            Circle secondCircle = GetSecondCircle(secondCircleParams);

            PrintResult(firstCircle, secondCircle);

        }

        private static Circle GetFirstCircle(int[] firstCircleParams)
        {
            Point firstPoint = new Point
            {
                X = firstCircleParams[0],
                Y = firstCircleParams[1]
            };

            Circle firstCircle = new Circle
            {
                Radius = firstCircleParams[2],
                Center = firstPoint
            };
            return firstCircle;
        }

        private static Circle GetSecondCircle(int[] secondCircleParams)
        {
            Point secondPoint = new Point
            {
                X = secondCircleParams[0],
                Y = secondCircleParams[1]
            };

            Circle secondCircle = new Circle
            {
                Radius = secondCircleParams[2],
                Center = secondPoint
            };
            return secondCircle;
        }

        private static void PrintResult(Circle firstCircle, Circle secondCircle)
        {
            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
    
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public static bool Intersect (Circle firstCircle, Circle secondCircle)
        {
            int deltaX = Math.Abs(firstCircle.Center.X - secondCircle.Center.X);
            int deltaY = Math.Abs(firstCircle.Center.Y - secondCircle.Center.Y);
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            int radiusSum = firstCircle.Radius + secondCircle.Radius;

            if (distance <= radiusSum)
            {
                return true;
            }
            return false;
        }
    }
}
