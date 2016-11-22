using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            arr1 = CondenseTheArray(arr1);

            Console.WriteLine(string.Join(" ", arr1));
        }

        private static int[] CondenseTheArray(int[] arr1)
        {
            while (arr1.Length > 1)
            {
                var tempArr = new int[arr1.Length - 1];
                for (int i = 0; i < tempArr.Length; i++)
                {
                    tempArr[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = new int[tempArr.Length];
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = tempArr[i];
                }
            }

            return arr1;
        }
    }
}
