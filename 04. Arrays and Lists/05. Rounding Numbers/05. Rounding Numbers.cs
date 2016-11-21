using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var rounded = new int[input.Length];

            RoundAndPrintTheNumbers(input, rounded);
        }

        private static void RoundAndPrintTheNumbers(decimal[] input, int[] rounded)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0) rounded[i] = (int)Math.Floor(input[i] + 0.5m);
                else rounded[i] = (int)Math.Ceiling(input[i] - 0.5m);
                Console.WriteLine("{0} => {1}", input[i], rounded[i]);
            }
        }
    }
}
