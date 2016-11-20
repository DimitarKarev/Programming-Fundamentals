using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] stringArr = input.Split(' ');
            var intArr = new long[stringArr.Length];
            bool noSum = true;
            ConvertingToIntegers(stringArr, intArr);
            noSum = CheckingForSums(intArr, noSum);
            if (noSum) Console.WriteLine("No");
        }

        private static void ConvertingToIntegers(string[] stringArr, long[] intArr)
        {
            for (long i = 0; i < intArr.Length; i++)
            {
                intArr[i] = long.Parse(stringArr[i]);
            }
        }

        private static bool CheckingForSums(long[] intArr, bool noSum)
        {
            for (int a = 0; a < intArr.Length; a++)
                for (int b = a + 1; b < intArr.Length; b++)
                {
                    long sum = intArr[a] + intArr[b];
                    if (intArr.Contains(sum))
                    {
                        Console.WriteLine($"{intArr[a]} + {intArr[b]} == {sum}");
                        noSum = false;
                    }
                }
            return noSum;
        }

       
    }
}
