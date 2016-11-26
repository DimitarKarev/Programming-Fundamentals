using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noSum = true;

            noSum = CheckForElement(numbers, noSum);
            if (noSum) Console.WriteLine("no");
        }

        private static bool CheckForElement(int[] numbers, bool noSum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;

                leftSum = GetLeftSum(numbers, i, leftSum);
                rightSum = GetRightSum(numbers, i, rightSum);
                noSum = PrintElement(numbers, noSum, i, leftSum, rightSum);
            }

            return noSum;
        }

        private static int GetLeftSum(int[] numbers, int i, int leftsum)
        {
            for (int left = 0; left < i; left++)
            {
                leftsum += numbers[left];
            }

            return leftsum;
        }

        private static int GetRightSum(int[] numbers, int i, int rightsum)
        {
            for (int right = i + 1; right < numbers.Length; right++)
            {
                rightsum += numbers[right];
            }

            return rightsum;
        }

        private static bool PrintElement(int[] numbers, bool noSum, int i, int leftsum, int rightsum)
        {
            if (leftsum == rightsum)
            {
                Console.WriteLine(Array.IndexOf(numbers, numbers[i]));
                noSum = false;
            }

            return noSum;
        }
    }
}
