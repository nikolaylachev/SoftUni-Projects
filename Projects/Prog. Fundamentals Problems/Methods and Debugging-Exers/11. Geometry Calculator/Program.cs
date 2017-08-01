using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void GetAreaTR(string typeOfFigure, double first, double second)
        {
            double area = 0.0;
            switch (typeOfFigure)
            {
                case "triangle":
                    {
                        area = (first * second) / 2;
                        Console.WriteLine($"{area:f2}");
                    }
                    break;
                case "rectangle":
                    {
                        area = first * second;
                        Console.WriteLine($"{area:f2}");
                    }
                    break;

                default:
                    break;
            }
        }
        static void GetAreaSC (string type, double first)
        {
            double area = 0.0;
            switch (type)
            {
               
                case "square":
                    {
                        area = Math.Pow(first, 2);
                        Console.WriteLine($"{area:f2}");
                    }
                    break;
                case "circle":
                    {
                      area = Math.PI * Math.Pow(first,2);
                        Console.WriteLine($"{area:f2}");
                    }
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "triangle" || type == "rectangle")
            {
                double first = double.Parse(Console.ReadLine());
                double second = double.Parse(Console.ReadLine());
                 GetAreaTR(type,first,second);

            }
            else if (type == "square" || type == "circle")
            {
                double first = double.Parse(Console.ReadLine());
                GetAreaSC(type, first);
            }

        }
    }
}
