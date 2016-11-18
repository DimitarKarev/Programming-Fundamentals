using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(num, power));
        }

        private static double RaiseToPower(double num, int power)
        {
            var numOnPower = num;
            for (int i = 1; i < power; i++)
            {
                numOnPower *= num;
            }
            return numOnPower;
        }
    }
}
