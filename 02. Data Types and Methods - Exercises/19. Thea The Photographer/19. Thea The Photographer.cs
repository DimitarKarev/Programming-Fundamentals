using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(pictures * (filterFactor / 100.0));
            var filterSeconds = pictures * filterTime;
            var uploadSeconds = (long)(filteredPictures * uploadTime);
            long totalTime = filterSeconds + uploadSeconds;

            var days = totalTime / (86400);
            var hours = (totalTime / 3600) - 24 * days;
            var minutes = (totalTime  - (24 * 3600 * days) - (3600 * hours))/60;
            var seconds = totalTime - 24 * 3600 * days - 3600 * hours - 60 * minutes;
            Console.Write($"{days}:");
            if (hours <= 9) Console.Write("0{0}:",hours);
            else Console.Write("{0}:", hours);
            if (minutes <= 9) Console.Write("0{0}:", minutes);
            else Console.Write("{0}:", minutes);
            if (seconds <= 9) Console.WriteLine("0{0}", seconds);
            else Console.WriteLine("{0}", seconds);
        }
    }
}
