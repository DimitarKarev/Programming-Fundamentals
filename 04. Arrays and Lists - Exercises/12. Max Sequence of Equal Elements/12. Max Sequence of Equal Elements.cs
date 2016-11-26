using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> longestSequence = new List<int>();
            var current = 1;
            var longest = 1;
            var number = numbers[0];

            GetLongestSequence(numbers, ref current, ref longest, ref number);

            PrintLongestSequence(longestSequence, longest, number);
        }

        private static void GetLongestSequence(List<int> numbers, ref int current, ref int longest, ref int number)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    current++;
                    if (current > longest)
                    {
                        longest = current;
                        number = numbers[i];
                    }
                }
                else
                {
                    current = 1;
                }
            }
        }

        private static void PrintLongestSequence(List<int> longestSequence, int longest, int number)
        {
            for (int i = 0; i < longest; i++)
            {
                longestSequence.Add(number);
            }
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
