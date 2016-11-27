using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Array_Manipulator
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToArray();
            
            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    AddElement(numbers, command);
                }

                else if (command[0] == "addMany")
                {
                    AddElements(numbers, command);
                }

                else if (command[0] == "contains")
                {
                    CheckIfListContainsElement(numbers, command);
                }

                else if (command[0] == "remove")
                {
                    RemoveElement(numbers, command);
                }

                else if (command[0] == "shift")
                {
                    ShiftPositions(numbers, command);
                }

                else if (command[0] == "sumPairs")
                {
                    SumPairs(numbers);
                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void AddElement(List<int> numbers, string[] command)
        {
            int index = int.Parse(command[1]);
            int element = int.Parse(command[2]);
            numbers.Insert(index, element);
        }

        private static void AddElements(List<int> numbers, string[] command)
        {
            int index = int.Parse(command[1]);
            var range = new int[command.Length - 2];
            for (int i = 0; i < range.Length; i++)
            {
                range[i] = int.Parse(command[i + 2]);
            }
            numbers.InsertRange(index, range);
        }

        private static void CheckIfListContainsElement(List<int> numbers, string[] command)
        {
            int element = int.Parse(command[1]);
            if (numbers.Contains(element))
            {
                Console.WriteLine(numbers.IndexOf(element));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static void RemoveElement(List<int> numbers, string[] command)
        {
            int index = int.Parse(command[1]);
            numbers.RemoveAt(index);
        }

        private static void ShiftPositions(List<int> numbers, string[] command)
        {
            var pos = int.Parse(command[1]);
            int temp = 0;
            for (int i = 0; i < pos; i++)
            {
                temp = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(temp);
            }
        }

        private static void SumPairs(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }
    }
}
