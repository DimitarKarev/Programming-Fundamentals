using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abc";
            string b = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }
            Console.WriteLine(b);
        }
    }
}
