﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + n; i++)
            for (char j = 'a'; j < 'a' + n; j++)
            for (char k = 'a'; k < 'a' + n; k++)
            Console.WriteLine($"{i}{j}{k}");
        }
    }
}
