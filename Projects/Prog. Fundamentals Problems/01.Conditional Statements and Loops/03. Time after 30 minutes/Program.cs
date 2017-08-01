using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Time_after_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes =int.Parse(Console.ReadLine());
            int newHours = (((hours * 60) + minutes + 30) / 60);
            int newMinutes = (((hours * 60) + minutes + 30) % 60);
            if (newHours <= 23)
            {
                Console.WriteLine("{0}:{1:D2}", newHours, newMinutes); 
            }
            else if(newHours==24)
            {
                newHours = 0;
                Console.WriteLine($"{newHours}:{newMinutes:D2}");
            }

        }
    }
}
