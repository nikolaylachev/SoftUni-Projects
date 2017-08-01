using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string impertialUnit = Console.ReadLine();
            double numberInImpertialUnit = double.Parse(Console.ReadLine());
            double numberInMetricUnit = 0.0D;
            switch (impertialUnit)
            {
                case "miles":
                    numberInMetricUnit = numberInImpertialUnit * 1.6D;
                    Console.WriteLine($"{numberInImpertialUnit} {impertialUnit} = {numberInMetricUnit:f2} kilometers");
                    break;
                case "inches":
                    numberInMetricUnit = numberInImpertialUnit * 2.54D;
                    Console.WriteLine($"{numberInImpertialUnit} {impertialUnit} = {numberInMetricUnit:f2} centimeters");
                    break;
                case "feet":
                    numberInMetricUnit = numberInImpertialUnit * 30.0D;
                    Console.WriteLine($"{numberInImpertialUnit} {impertialUnit} = {numberInMetricUnit:f2} centimeters");
                    break;
                case "yards":
                    numberInMetricUnit = numberInImpertialUnit * 0.91D;
                    Console.WriteLine($"{numberInImpertialUnit} {impertialUnit} = {numberInMetricUnit:f2} meters");
                    break;
                case "gallons":
                    numberInMetricUnit = numberInImpertialUnit * 3.8D;
                    Console.WriteLine($"{numberInImpertialUnit} {impertialUnit} = {numberInMetricUnit:f2} liters");
                    break;
                default:
                    break;
            }
        }
    }
}
