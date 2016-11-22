using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            bool empty = true;
            empty = InsertIntegersInList(array, numbers, empty);

            if (empty) Console.WriteLine("empty");
            else Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool InsertIntegersInList(int[] array, List<int> numbers, bool empty)
        {
            foreach (var item in array)
            {
                if (item >= 0)
                {
                    numbers.Add(item);
                    empty = false;
                }
            }
            numbers.Reverse();
            return empty;
        }
    }
}
