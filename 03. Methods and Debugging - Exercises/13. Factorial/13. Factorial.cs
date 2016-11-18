using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
           var n = int.Parse(Console.ReadLine());
           FindFactorial(n);
        }

        private static void FindFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            FindTailingZeros(factorial);
        }

        private static void FindTailingZeros(BigInteger factorial)
        {
            BigInteger digit = 0;
            var counter = 0;
            while (factorial > 0)
            {
                digit = factorial % 10;
                if (digit == 0) counter++;
                else break;
                factorial /= 10;
            }
            Console.WriteLine(counter);
        }
    }
}
