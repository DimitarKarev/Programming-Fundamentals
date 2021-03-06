﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintingTriangleTop(n);
            PrintingTriangleBottom(n);
        }

        private static void PrintingTriangleTop(int n)
        {
            for (int row = 1; row <= n; row++)
            {
              for (int col = 1; col <= row; col++)
              {
                  Console.Write($"{col} ");
              }
              Console.WriteLine();
            }
                    }
        private static void PrintingTriangleBottom(int n)
        {
            for (int row = n - 1; row >= 1; row--)
            {
              for (int col = 1; col <= row; col++)
              {
                  Console.Write($"{col} ");
              }
              Console.WriteLine();
            }
        }
    }
}
