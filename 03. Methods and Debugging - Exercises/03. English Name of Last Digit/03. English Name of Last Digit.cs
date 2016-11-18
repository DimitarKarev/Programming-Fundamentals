using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            NameOfLastDigit(num);
        }

        private static void NameOfLastDigit(long num)
        {
            switch (GetLastDigit(num))
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("zero"); break;
            }
        }

        private static long GetLastDigit(long num)
        {
            var lastDigit = Math.Abs(num) % 10;
            return lastDigit;
        }
    }
}
