using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var longest = 1;
            var number = inputArray[0];
            var current = 1;

            GetLongestSequence(inputArray, ref longest, ref number, ref current);
            PrintLongestSequence(longest, number);
        }

        private static void GetLongestSequence(int[] inputArray, ref int longest, ref int number, ref int current)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1])
                {
                    current++;
                    if (current > longest)
                    {
                        longest = current;
                        number = inputArray[i];
                    }
                }
                else current = 1;
            }
        }

        private static void PrintLongestSequence(int longest, int number)
        {
            int[] output = new int[longest];
            for (int i = 0; i < longest; i++)
            {
                output[i] = number;
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
