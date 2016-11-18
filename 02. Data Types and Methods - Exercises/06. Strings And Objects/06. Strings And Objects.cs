using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = "Hello";
            var world = "World";
            object helloWorld = hello + " " + world;
            var helloWorldString = (string)helloWorld;
            Console.WriteLine(helloWorldString);
        }
    }
}
