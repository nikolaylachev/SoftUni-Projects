using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._2017_Exam_Problem_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int restingDays = int.Parse(Console.ReadLine());
            int workingDays = (365 - restingDays);
            int timeForPlaying = ((workingDays * 63) + (restingDays*127));//The norm is 30 000
           
            if (timeForPlaying < 30000)
            {
                int remaingTime = 30000 - timeForPlaying;
                int hours = remaingTime / 60;
                int minutes = remaingTime % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,minutes);
            }

            else if(timeForPlaying >= 30000)
            {
                int remaingTime = timeForPlaying - 30000;
                int hours = remaingTime / 60;
                int minutes = remaingTime % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours,minutes);
            }

        }
    }
}
