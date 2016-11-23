using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var Sqrt = 0.0;
            var intSqrt = 0;

            ExtractSquareNumbers(numbers, ref Sqrt, ref intSqrt);
            SortAndPrint(numbers);
        }

        private static void ExtractSquareNumbers(List<int> numbers, ref double Sqrt, ref int intSqrt)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Sqrt = Math.Sqrt(numbers[i]);
                intSqrt = (int)Math.Sqrt(numbers[i]);
                if (Sqrt != intSqrt)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void SortAndPrint(List<int> numbers)
        {
            numbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
