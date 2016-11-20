using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;

            GetingArrayValues(k, arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        private static void GetingArrayValues(int k, long[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                long sum = 0;
                var length = i - k;
                if (length < 0) length = 0;
                sum = SumLastKElement(arr, i, sum, length);
                arr[i] = sum;
            }
        }

        private static long SumLastKElement(long[] arr, int i, long sum, int length)
        {
            for (int j = length; j < i; j++)
            {
                sum += arr[j];
            }

            return sum;
        }
    }
}
