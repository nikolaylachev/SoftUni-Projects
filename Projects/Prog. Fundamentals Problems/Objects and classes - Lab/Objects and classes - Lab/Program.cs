using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] date = Console.ReadLine().Split('-');
            //DateTime newDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime newDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]),int.Parse(date[0]));
            Console.WriteLine(newDate.DayOfWeek);
        }
    }
}
