using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().ToArray();
            var arr2 = Console.ReadLine().Split().ToArray();
            var shorter = Math.Min(arr1.Length, arr2.Length);
            var leftLength = 0;
            var rightLength = 0;

            leftLength = GetLeftLength(arr1, arr2, shorter, leftLength);
            rightLength = GetRightLength(arr1, arr2, shorter, rightLength);

            Console.WriteLine(Math.Max(leftLength, rightLength));
        }

        private static int GetLeftLength(string[] arr1, string[] arr2, int shorter, int leftLength)
        {
            for (int i = 0; i < shorter; i++)
            {
                if (arr1[i] == arr2[i]) leftLength++;
                else break;
            }

            return leftLength;
        }

        private static int GetRightLength(string[] arr1, string[] arr2, int shorter, int rightLength)
        {
            for (int i = 0; i < shorter; i++)
            {
                if (arr1[arr1.Length - i - 1] == arr2[arr2.Length - i - 1]) rightLength++;
                else break;
            }

            return rightLength;
        }
    }
}
