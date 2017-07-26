using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void GetCubeProperties(double side, string property)
        {
            double formula = 0.0;
            switch (property)
            {
                case "face":
                    {
                        formula = Math.Sqrt((2.0*Math.Pow(side,2)));
                        Console.WriteLine($"{formula:f2}");
                    }
                    break;
                case "space":
                    {
                        formula = Math.Sqrt((3.0 * Math.Pow(side, 2)));
                        Console.WriteLine($"{formula:f2}");
                    }
                    break;
                case "volume":
                    {
                        formula = Math.Pow(side, 3);
                        Console.WriteLine($"{formula:f2}");
                    }
                    break;
                case "area":
                    {
                        formula = 6.0 * Math.Pow(side, 2);
                        Console.WriteLine($"{formula:f2}");
                    }
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            GetCubeProperties(side, property);
        }
    }
}
