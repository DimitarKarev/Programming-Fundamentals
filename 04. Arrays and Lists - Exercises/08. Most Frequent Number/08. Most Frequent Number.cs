using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mostFrequentNum = 0;
            int maxCounter = 0;

            GetMostFrequentNumber(numbers, ref mostFrequentNum, ref maxCounter);

            Console.WriteLine(mostFrequentNum);
        }

        private static void GetMostFrequentNumber(int[] numbers, ref int mostFrequentNum, ref int maxCounter)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            mostFrequentNum = numbers[i];
                        }
                    }
                }
            }
        }
    }
}
