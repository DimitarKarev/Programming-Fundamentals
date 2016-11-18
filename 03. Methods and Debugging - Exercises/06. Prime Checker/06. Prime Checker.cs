using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Prime(n));
        }

        private static bool Prime(long n)
        {
            bool isPrime = true;
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) isPrime = false;
            }
            if (n <= 1) isPrime = false;
            return isPrime;
        }
    }
}
