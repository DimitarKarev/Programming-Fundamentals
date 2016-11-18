using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            var trailingZeroes = 0;

            factorial = CalculateFactorial(n, factorial);
            trailingZeroes = CalcTrailingZeroes(factorial, trailingZeroes);

            Console.WriteLine(trailingZeroes);
        }

        private static int CalcTrailingZeroes(BigInteger factorial, int trailingZeroes)
        {
            BigInteger currentDigit;
            while (true)
            {
                currentDigit = factorial % 10;
                if (currentDigit == 0) trailingZeroes++;
                else break;
                factorial /= 10;
            }
            return trailingZeroes;
        }

        private static BigInteger CalculateFactorial(int n, BigInteger factorial)
        {
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
