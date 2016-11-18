using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray().Reverse();
            foreach (var item in input)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
