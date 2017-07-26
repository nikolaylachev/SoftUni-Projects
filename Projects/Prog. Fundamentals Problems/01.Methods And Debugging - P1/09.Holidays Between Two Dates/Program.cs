using System;
using System.Globalization;

namespace _09.Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] formats = { "dd.MM.yyyy", "d.M.yyyy", "dd.M.yyyy", "d.MM.yyyy" };
            var startingDate = Console.ReadLine();
            var endingDate = Console.ReadLine();
            var startDate = DateTime.ParseExact(startingDate, formats , new CultureInfo("bg-BG"), DateTimeStyles.None);
            var endDate = DateTime.ParseExact(endingDate, formats, new CultureInfo("bg-BG"), DateTimeStyles.None);

            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
