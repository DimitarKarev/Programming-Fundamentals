using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateAsText = Console.ReadLine();

            DateTime date = ConvertTextToDate(dateAsText);

            Console.WriteLine(date.DayOfWeek);
        }

        private static DateTime ConvertTextToDate(string dateAsText)
        {
            return DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
        }
    }
}
