using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                var number = num;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool special = false;
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {special}");
            }
        }
    }
}
