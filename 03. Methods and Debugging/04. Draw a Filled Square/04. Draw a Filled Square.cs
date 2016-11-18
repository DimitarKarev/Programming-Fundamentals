using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            DrawHeader(n);
            DrawMiddle(n);
            DrawHeader(n);
        }

        private static void DrawMiddle(int n)
        {
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write('-');
                for (int col = 0; col < n - 1; col++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');

            }
        }

        private static void DrawHeader(int n)
        {
            Console.WriteLine(new string('-',2 * n));
        }
    }
}
