using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var longest = 1;
            var startElement = inputArray[0];
            var current = 1;

            GetLongestSequence(inputArray, ref longest, ref startElement, ref current);
            PrintLongestSequence(inputArray, longest, startElement);
        }

        private static void GetLongestSequence(int[] inputArray, ref int longest, ref int startElement, ref int current)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > inputArray[i - 1])
                {
                    current++;
                    if (current > longest)
                    {
                        longest = current;
                        startElement = i - longest + 1;
                    }
                }
                else current = 1;
            }
        }

        private static void PrintLongestSequence(int[] inputArray, int longest, int startElement)
        {       
            int[] output = new int[longest];
            for (int i = 0; i < longest; i++)
            {
                output[i] = inputArray[startElement + i];
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
