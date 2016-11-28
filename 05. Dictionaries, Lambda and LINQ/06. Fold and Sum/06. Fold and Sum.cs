using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] row1Left = GetLeft(numbers, k);
            int[] row1Right = GetRight(numbers, k);
            int[] row1 = GetRow1(row1Left, row1Right);
            int[] row2 = GetRow2(numbers, k);
            SumAndPrint(row1, row2);

        }

        private static int[] GetLeft(int[] numbers, int k)
        {
            return numbers.Take(k)
                          .Reverse()
                          .ToArray();
        }

        private static int[] GetRight(int[] numbers, int k)
        {
            return numbers.Reverse()
                          .Take(k)
                          .ToArray();
        }

        private static int[] GetRow1(int[] row1Left, int[] row1Right)
        {
            return row1Left.Concat(row1Right)
                           .ToArray();
        }

        private static int[] GetRow2(int[] arr, int k)
        {
            return arr.Skip(k)
                      .Take(2 * k)
                      .ToArray();
        }

        private static void SumAndPrint(int[] row1, int[] row2)
        {
            var sum = row1.Select((x, index) => x + row2[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
