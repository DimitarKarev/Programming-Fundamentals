using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            factorial = CalcFactorial(n, factorial);

            Console.WriteLine(factorial);
        }

        private static BigInteger CalcFactorial(int n, BigInteger factorial)
        {
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
