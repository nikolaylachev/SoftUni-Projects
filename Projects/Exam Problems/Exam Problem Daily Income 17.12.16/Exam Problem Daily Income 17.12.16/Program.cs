using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_Daily_Income_17._12._16
{
    class Program
    {
        static void Main(string[] args)
        {

            int workingDaysInMonth = int.Parse(Console.ReadLine());
            decimal moneyPerDay = decimal.Parse(Console.ReadLine());
            decimal dollarCourse = decimal.Parse(Console.ReadLine());


            decimal monthSallary = workingDaysInMonth * moneyPerDay;
            decimal yearIncome = (12 * monthSallary) + (2.5m*monthSallary);
            decimal tax = (yearIncome * 0.25m);
            decimal netYearIncomeInLeva = ((yearIncome - tax)*dollarCourse);
            decimal averageIncomePerDay = (netYearIncomeInLeva / 365);
            //Console.WriteLine("year income= {0} tax= {1} net year income= {2}",yearIncome,tax,netYearIncomeInLeva);
            Console.WriteLine(Math.Round(averageIncomePerDay,2));

        }
    }
}
