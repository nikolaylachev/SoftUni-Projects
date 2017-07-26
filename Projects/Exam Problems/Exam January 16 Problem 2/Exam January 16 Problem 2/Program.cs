using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBricks = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int numberOfBricksPerWorker = int.Parse(Console.ReadLine());

            int totalBricksPerCourse = numberOfWorkers * numberOfBricksPerWorker;

            int numberOfCourses = numberOfBricks/totalBricksPerCourse;
           
            //Console.WriteLine("{0}",numberOfBricks%totalBricksPerCourse);
            if (numberOfBricks % totalBricksPerCourse < totalBricksPerCourse)
            {
                numberOfCourses++;
            }
            if (numberOfBricks % totalBricksPerCourse == 0)
            {
                numberOfCourses -= 1;
            }
            Console.WriteLine(numberOfCourses);
        }
    }
}
