using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_Exam_Hall_17._12._16
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMeters = double.Parse(Console.ReadLine());//15 / 8.4
            double widthInMeters = double.Parse(Console.ReadLine());//8.9 / 5.2
            double heightInCentimeters = heightInMeters * 100;
            double widthInCentimeters = widthInMeters * 100;
            //Console.WriteLine("{0} {1}",heightInCentimeters, widthInCentimeters);
            int numberOfRows = (int)heightInCentimeters  / 120;
            int numberOfDesks = ((int)widthInCentimeters  - 100) / 70;
            /*Console.WriteLine(numberOfRows);
            Console.WriteLine(numberOfDesks);*/
            Console.WriteLine((numberOfDesks*numberOfRows)-3);
        }
    }
}
