using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var minLength = Math.Min(arr1.Length, arr2.Length);

            CompareAndPrintArrays(arr1, arr2, minLength);
        }

        private static void CompareAndPrintArrays(char[] arr1, char[] arr2, int minLength)
        {
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    return;
                }
                else if (arr2[i] > arr1[i])
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    return;
                }
                else if (arr1.Length == arr2.Length && arr1[i] == arr2[i])
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr1));
                    return;
                }
            }
            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
            else
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
        }
    }
}
