using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bomb[0], power = bomb[1];

            GetRemainingNumbers(numbers, bombNumber, power);
            Console.WriteLine(numbers.Sum());
        }

        private static void GetRemainingNumbers(List<int> numbers, int bombNumber, int power)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int start = Math.Max(i - power, 0);
                    int end = Math.Min(i + power, numbers.Count - 1);
                    int length = end - start + 1;
                    numbers.RemoveRange(start, length);
                    i = 0;
                }
            }
        }
    }
}
