using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_3
{
    class Program
    {
        static int GetDaysInMonth(int month,int year)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);

            //int intVar = 5;
            //long longVar = 5L;
            //double doubleVar = 5.5D;

            //double multiply = (double)intVar * longVar * doubleVar;



            return daysInMonth;
        }

        static void Main(string[] args)
        {


            decimal priceOfCoffe = 0M;
             decimal totalPriceOfCoffee = 0M;

             var n = int.Parse(Console.ReadLine());
             for (int i = 1; i <= n; i++)
             {
                 decimal pricePerCapsule = decimal.Parse(Console.ReadLine());//79228162514264337593543950335

                 string dateFromCommand = Console.ReadLine();
                 var date = dateFromCommand.Split('/');

                 int day = int.Parse(date[0]);
                 int month = int.Parse(date[1]);
                 int year = int.Parse(date[2]);

                 long capsulesCount = long.Parse(Console.ReadLine());

                 int daysInMonth = GetDaysInMonth(month, year);

                 priceOfCoffe = (decimal)(daysInMonth * capsulesCount) * pricePerCapsule;
                 //priceOfCoffe = Math.Round(priceOfCoffe, 2);
                 Console.WriteLine($"The price for the coffee is: ${priceOfCoffe:F2}");
                 totalPriceOfCoffee += priceOfCoffe;
             }
             //totalPriceOfCoffee = Math.Round(totalPriceOfCoffee, 2);
             Console.WriteLine($"Total: ${totalPriceOfCoffee:f2}");
             
          

        }
    }
}
