using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._2017_Exam_Problem_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int givenDays = int.Parse(Console.ReadLine());
            int numberOFEmployees = int.Parse(Console.ReadLine());
            double workingHours = (givenDays * 0.9) * 8;
            double hoursForExtraWorking = numberOFEmployees * (2 * givenDays);
            double totalHours = workingHours + hoursForExtraWorking;
           // Console.WriteLine("{0} {1} {2}",workingHours,hoursForExtraWorking,totalHours);
            if (totalHours>=hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.",Math.Floor(totalHours-hoursNeeded));
            }
            else if (totalHours<hoursNeeded)
            {
                Console.WriteLine("Not enough time!{0} hours needed.",Math.Ceiling(hoursNeeded-totalHours));
            }
            

        }
    }
}
