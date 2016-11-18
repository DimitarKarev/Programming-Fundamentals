using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (SumOfDigitsDividesBy7(i) && IsPalindrome(i) && HoldsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int i)
        {
            bool isPalindrome = true;
            string number = Convert.ToString(i);
            string reversed = "";
            for (int j = number.Length - 1; j >= 0; j--)
            {
                reversed += number[j];
            }
            if (number != reversed) isPalindrome = false;
            return isPalindrome;
        }

        private static bool SumOfDigitsDividesBy7(int i)
        {
            var sum = 0;
            bool IsDivisibleBy7 = false;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0) IsDivisibleBy7 = true;
            return IsDivisibleBy7;
        }
            
        private static bool HoldsEvenDigit(int i)
        {
            bool evenDigit = false;
            while (i > 0)
            {
                var digit = i % 10;
                if (digit % 2 == 0) evenDigit = true;
                i /= 10;
            }
            return evenDigit;
        }
    }
}
