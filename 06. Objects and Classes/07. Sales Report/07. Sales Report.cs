﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();

            string[] towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToArray();
            foreach (string town in towns)
            {
                decimal salesByTown = sales.Where(s => s.Town == town)
                  .Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }

        }
        
        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }

        static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split(' ');
            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

    }

}