using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            var totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            float totalHours = totalSeconds / 3600f;
            float metersPerSecond = (float)distance / totalSeconds;
            float kilometersPerHour = distance / 1000f / totalHours;
            float milesPerHour = distance / 1609f / totalHours;
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
