using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = int.Parse(Console.ReadLine());
            var lastChar = int.Parse(Console.ReadLine());
            for (char i = (char)firstChar; i <= (char)lastChar; i++)
            {
                Console.Write(i +" ");
            }
        }
    }
}
