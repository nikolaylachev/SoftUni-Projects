using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_21._01._17_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfWeekendsInHometown = int.Parse(Console.ReadLine());

            double weekendsInSofia = ((48 - numberOfWeekendsInHometown) * 3.0 )/ 4.0;
            double numberOfGamesDuringHolidays = (numberOfHolidays *2.0)/ 3.0;
            //Console.WriteLine(numberOfGamesDuringHolidays);
            double totalGames = weekendsInSofia + numberOfWeekendsInHometown + numberOfGamesDuringHolidays;
            if (yearType=="leap")
            {
                Console.WriteLine(Math.Floor((totalGames*0.15)+totalGames));
            }
            else if (yearType=="normal")
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
        }
    }
}
