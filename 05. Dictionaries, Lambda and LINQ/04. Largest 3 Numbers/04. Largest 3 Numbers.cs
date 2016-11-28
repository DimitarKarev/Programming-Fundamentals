using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GetLargest3Numbers();

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static int[] GetLargest3Numbers()
        {
            return Console.ReadLine().Split()
                                     .Select(int.Parse)
                                     .OrderByDescending(x => x)
                                     .Take(3)
                                     .ToArray();
        }
    }
}
