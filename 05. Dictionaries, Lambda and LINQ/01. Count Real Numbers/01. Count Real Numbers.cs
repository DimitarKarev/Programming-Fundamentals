using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            CountOccurrences(numbers, counts);
            PrintNumbers(counts);
        }

        private static void CountOccurrences(double[] numbers, SortedDictionary<double, int> counts)
        {
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }
        }

        private static void PrintNumbers(SortedDictionary<double, int> counts)
        {
            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
