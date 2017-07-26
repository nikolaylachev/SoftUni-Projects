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
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float timeInSeconds = ((hours * 3600) + (minutes * 60) + seconds);
            Console.WriteLine(timeInSeconds);
            float metersPerSeconds = (distanceInMeters / timeInSeconds);
            float kilometersPerHour = (float)(metersPerSeconds * 3.6d);
            float milesPerHours = kilometersPerHour * 0.621504065F;
            Console.WriteLine($"{metersPerSeconds}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHours}");
        }
    }
}
