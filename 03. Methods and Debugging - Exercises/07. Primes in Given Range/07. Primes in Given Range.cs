using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            PrintPrimes(startNum, endNum);
        }

        private static void PrintPrimes(int startNum, int endNum)
        {
            bool noPrimes = true;
            var counter = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    if (counter == 0) Console.Write("{0}", i);
                    else Console.Write(", {0}", i);
                    counter++;
                }
                noPrimes = false;
            }
            if (noPrimes) Console.WriteLine("(empty list)");
            else Console.WriteLine();
        }

        private static bool IsPrime(int i)
        {
            bool isPrime = true;
            for (long j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0) isPrime = false;
            }
            if (i <= 1) isPrime = false;
            return isPrime;
        }
    }
}
