using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            List<int> reversed = new List<int>();
            var sum = 0;

            ReverseNumbers(numbers, reversed);
            sum = CalcAndPrintSum(reversed, sum);
        }

        private static void ReverseNumbers(List<string> numbers, List<int> reversed)
        {
            foreach (var number in numbers)
            {
                var reversedString = string.Empty;
                number.ToCharArray();
                for (int i = 0; i < number.Length; i++)
                {
                    reversedString += number[number.Length - i - 1];
                }
                reversed.Add(int.Parse(reversedString));
            }
        }

        private static int CalcAndPrintSum(List<int> reversed, int sum)
        {
            foreach (var num in reversed)
            {
                sum += num;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
