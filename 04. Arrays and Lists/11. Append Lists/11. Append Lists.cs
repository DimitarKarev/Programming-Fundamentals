﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();
            var result = new List<string>();
            AppendLists(items, result);
            Console.WriteLine(string.Join(" ", result));
        }

        private static void AppendLists(List<string> items, List<string> result)
        {
            foreach (var item in items)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }
        }
    }
}
