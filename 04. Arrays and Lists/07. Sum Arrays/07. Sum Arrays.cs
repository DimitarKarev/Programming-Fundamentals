using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var shorterArray = Math.Min(arr1.Length, arr2.Length);
            var longerArray = Math.Max(arr1.Length, arr2.Length);
            var arrSum = new int[longerArray];

            for (int i = 0; i < arrSum.Length; i++)
            {   
                arrSum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ",arrSum));
        }
    }
}
