using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));
            MultiplyEvenByOdd(n);
        }

        private static void MultiplyEvenByOdd( int n)
        {
            var evenSum = 0;
            var oddSum = 0;
            int num;
            while (n > 0)
            {
              num = n % 10;
                if (num % 2 == 0) evenSum += num;
                else oddSum += num;
                n /= 10;
            }
            var multiplyEvenByOdd = oddSum * evenSum;
            Console.WriteLine(multiplyEvenByOdd);
        }
    }
}
