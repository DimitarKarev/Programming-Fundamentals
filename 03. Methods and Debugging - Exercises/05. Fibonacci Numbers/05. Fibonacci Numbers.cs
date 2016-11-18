using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          var n = int.Parse(Console.ReadLine());
          Console.WriteLine(Fibonacci(n));
        }

        private static long Fibonacci(int n)
        {
            long oldnum = 1;
            long oldsum = 1;
            long sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sum = oldnum + oldsum;
                oldnum = oldsum;
                oldsum = sum;
            }
            return oldsum;
        }
    }
}
