using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            Console.WriteLine(ReverseNumber(n));
        }

        private static string ReverseNumber(string n)
        {
            var reversed = "";
            for (int i = n.Length - 1; i >= 0; i--)
            {
                reversed += n[i];
            }
            return reversed;
        }
    }
}
