using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var cubeSide = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();
            switch (parameter)
            {
                case "face": FindFace(cubeSide); break;
                case "space": FindSpace(cubeSide); break;
                case "volume": FindVolume(cubeSide); break;
                case "area": FindArea(cubeSide); break;
                default: break;
            }
        }

        private static void FindFace(double cubeSide)
        {
            var result = Math.Sqrt(2*(cubeSide * cubeSide));
            Console.WriteLine("{0:f2}", Math.Round(result,2));
        }

        private static void FindSpace(double cubeSide)
        {
            var result = Math.Sqrt(3 * (cubeSide * cubeSide));
            Console.WriteLine("{0:f2}", Math.Round(result, 2));
        }

        private static void FindVolume(double cubeSide)
        {
            var result = cubeSide * cubeSide * cubeSide;
            Console.WriteLine("{0:f2}", Math.Round(result, 2));
        }

        private static void FindArea(double cubeSide)
        {
            var result = 6 * (cubeSide * cubeSide);
            Console.WriteLine("{0:f2}", Math.Round(result, 2));
        }
    }
}
