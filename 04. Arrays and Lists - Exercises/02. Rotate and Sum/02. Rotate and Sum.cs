using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var temp = new int[array.Length];
            var sum = new int[array.Length];
            var k = int.Parse(Console.ReadLine());

            SumAllRotations(array, temp, sum, k);

            Console.WriteLine(string.Join(" ", sum));
        }

        private static void SumAllRotations(int[] array, int[] temp, int[] sum, int k)
        {
            for (int rotations = 0; rotations < k; rotations++)
            {
                RotateArray(array, temp);

                ApplyRotationToArray(array, temp);

                AddRotationToSum(array, temp, sum);
            }
        }

        private static void RotateArray(int[] array, int[] temp)
        {
            temp[0] = array[array.Length - 1];
            for (int i = 1; i < array.Length; i++)
            {
                temp[i] = array[i - 1];
            }
        }

        private static void ApplyRotationToArray(int[] array, int[] temp)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
        }

        private static void AddRotationToSum(int[] array, int[] temp, int[] sum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum[i] += temp[i];
            }
        }
    }
}
