using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            double distanceOfFirstPoint = Math.Sqrt(Math.Pow((x1 - 0), 2) + Math.Pow((y1 - 0), 2));
            double distanceOfSecondPoint = Math.Sqrt(Math.Pow((x2 - 0), 2) + Math.Pow((y2 - 0), 2));
            if (distanceOfFirstPoint > distanceOfSecondPoint)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;

        }
        static void Main(string[] args)
        {
            //d = sqrt((x2-x1)^2 + (y2-y1)^2)
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());
            //GetCloserPoint(x1, y1, x2, y2);
            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());
            if((GetDistanceBetweenTwoPoints(firstX1,firstY1,firstX2,firstY2)) > 
                (GetDistanceBetweenTwoPoints(secondX1,secondY1,secondX2,secondY2)))
            {
                GetCloserPoint(firstX1, firstY1, firstX2, firstY2);
            }
            else
            {
                GetCloserPoint(secondX1, secondY1, secondX2, secondY2);
            }
        }
    }
}
