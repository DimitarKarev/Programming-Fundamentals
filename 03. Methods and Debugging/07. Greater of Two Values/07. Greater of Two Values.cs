using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            
            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax( first, second));
            }
            else if (type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else 
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }

        }

        private static int GetMax(int first, int second)
        {
            var max = Math.Max(first, second);
            return max;
        }

        private static char GetMax(char first, char second)
        {
            var max = Math.Max(first, second);
            return (char)max;
        }

        private static string GetMax(string first, string second)
        {
            var max = string.Compare(first, second);
            if (max >= 0) return first;
            else return second;
        }
    }
}
