using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = array.Length;
            ExtractMiddleElement(array, length);
        }

        private static void ExtractMiddleElement(int[] array, int length)
        {
            if (length == 1) Console.WriteLine("{ " + array[0] + " }");

            else if (array.Length % 2 == 0) Console.WriteLine("{ " + $"{array[length / 2 - 1]}, {array[length / 2]}" + " }");

            else Console.WriteLine("{ " + $"{array[length / 2 - 1]}, {array[length / 2]}, {array[length / 2 + 1]}" + " }");
        }
    }
}
