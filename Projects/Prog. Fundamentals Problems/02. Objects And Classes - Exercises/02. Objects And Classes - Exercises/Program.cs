using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Objects_And_Classes___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startDate = Console.ReadLine().Split('-');
            string[] endDate = Console.ReadLine().Split('-');
            DateTime startingDate = new DateTime(int.Parse(startDate[2]), int.Parse(startDate[1]), int.Parse(startDate[0]));
            DateTime endingDate = new DateTime(int.Parse(endDate[2]), int.Parse(endDate[1]), int.Parse(endDate[0]));

            DateTime[] holidays = new DateTime[11];
            holidays[0] = new DateTime(startingDate.Year, 1, 1);
            holidays[1] = new DateTime(startingDate.Year, 3, 3);
            holidays[2] = new DateTime(startingDate.Year, 5, 1);
            holidays[3] = new DateTime(startingDate.Year, 5, 6);
            holidays[4] = new DateTime(startingDate.Year, 5, 24);
            holidays[5] = new DateTime(startingDate.Year, 9, 6);
            holidays[6] = new DateTime(startingDate.Year, 9, 22);
            holidays[7] = new DateTime(startingDate.Year, 11, 1);
            holidays[8] = new DateTime(startingDate.Year, 12, 24);
            holidays[9] = new DateTime(startingDate.Year, 12, 25);
            holidays[10] = new DateTime(startingDate.Year, 12, 26);

            int workingDaysCounter = 0;
            for (DateTime day = startingDate.Date; day <= endingDate.Date; day = day.AddDays(1))
            {
                if (holidays.Contains(day) || (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday))
                {
                    workingDaysCounter += 0;
                }
                else
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine($"{workingDaysCounter}");
        }
    }
}
