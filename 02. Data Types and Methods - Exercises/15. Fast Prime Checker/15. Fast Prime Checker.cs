using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int divident = 2; divident <= n; divident++)
            {
                bool prime = true;
                for (int divider = 2; divider <= Math.Sqrt(divident); divider++)
                {
                    if (divident % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{divident} -> {prime}");
            }
        }
    }
}
