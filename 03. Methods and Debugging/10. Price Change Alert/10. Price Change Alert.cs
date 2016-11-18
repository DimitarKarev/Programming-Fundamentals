using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Price_Change_Alert
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double significance = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double c = double.Parse(Console.ReadLine());
                double div = Proc(lastPrice, c); bool isSignificantDifference = imaliDif(div, significance);
                string message = Get(c, lastPrice, div, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = c;
            }
        }

        private static string Get(double c, double last, double dif, bool etherTrueOrFalse)
        {
            string to = "";
            if (dif == 0)
            {
                to = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, dif);
            }
            else if (etherTrueOrFalse && (dif > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, dif);
            }
            else if (etherTrueOrFalse && (dif < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, dif);
            return to;
        }
        private static bool imaliDif(double significance, double isDiff)
        {
            if (Math.Abs(significance) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double l, double c)
        {
            double r = ((c - l) / l)* 100;
            return r;
        }
    }
}
