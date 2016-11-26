using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());
            int counter = 0;

            counter = CountPairs(numbers, difference, counter);

            Console.WriteLine(counter);
        }

        private static int CountPairs(int[] numbers, int difference, int counter)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[j] - numbers[i]) == difference) counter++;

                }
            }

            return counter;
        }
    }
}
