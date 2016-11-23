using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SumNumbers(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SumNumbers(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        if (i > 0) i--;
                    }
                    else i++;
                }
            }
        }
    }
}
