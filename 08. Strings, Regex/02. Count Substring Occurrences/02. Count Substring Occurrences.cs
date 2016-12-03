﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;

            counter = CountOccurrences(input, pattern, counter);

            Console.WriteLine(counter);
        }

        private static int CountOccurrences(string input, string pattern, int counter)
        {
            int index = input.IndexOf(pattern);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }

            return counter;
        }
    }
}
