using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counts = new int[1001];

            CountOccurrences(nums, counts);
            PrintNumbersInAscendingOrder(counts);
        }

        private static void CountOccurrences(List<int> nums, int[] counts)
        {
            foreach (var num in nums)
            {
                counts[num]++;
            }
        }

        private static void PrintNumbersInAscendingOrder(int[] counts)
        {
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0) Console.WriteLine($"{i} -> {counts[i]}");
            }
        }
    }
}
