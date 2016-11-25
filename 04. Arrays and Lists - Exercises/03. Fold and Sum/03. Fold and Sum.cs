using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = array.Length / 4;
            var leftSide = new int[k];
            var rightSide = new int[k];
            var middle = new int[2 * k];
            var sum = new int[2 * k];

            ExtractLeftMiddleRight(array, k, leftSide, rightSide, middle);

            SumAndPrintTheArray(k, leftSide, rightSide, middle, sum);
        }

        private static void ExtractLeftMiddleRight(int[] array, int k, int[] leftSide, int[] rightSide, int[] middle)
        {
            for (int i = 0; i < k; i++)
            {
                leftSide[i] = array[i];
            }
            Array.Reverse(leftSide);

            for (int i = 0; i < k; i++)
            {
                rightSide[i] = array[array.Length - i - 1];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                middle[i] = array[i + k];
            }
        }

        private static void SumAndPrintTheArray(int k, int[] leftSide, int[] rightSide, int[] middle, int[] sum)
        {
            for (int i = 0; i < 2 * k; i++)
            {
                if (i < k) sum[i] = leftSide[i] + middle[i];
                else sum[i] = rightSide[i - k] + middle[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
