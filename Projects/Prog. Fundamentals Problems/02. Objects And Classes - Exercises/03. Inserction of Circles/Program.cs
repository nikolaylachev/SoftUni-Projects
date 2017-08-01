using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Inserction_of_Circles
{
    class Program
    {
        class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static double GetDistanceBetweenCenters(Circle c1, Circle c2)
        {
            double distance = Math.Sqrt(Math.Pow((c2.Center.X - c1.Center.X), 2) + Math.Pow((c2.Center.Y - c1.Center.Y), 2));
            return distance;
        }

        static bool Intersect (Circle c1, Circle c2)
        {
            double distance = GetDistanceBetweenCenters(c1, c2);
            bool isIntersect = false;
            if (c1.Radius + c2.Radius >= distance)
            {
                isIntersect = true;
            }
            else if ((c1.Radius + c2.Radius) < distance)
            {
                isIntersect = false;
            }
            return isIntersect;
        }

        static void Main(string[] args)
        {
            string[] firstCircle = Console.ReadLine().Split(' ').ToArray();
            string[] secondCircle = Console.ReadLine().Split(' ').ToArray();
            Point firstCenter = new Point() {X = int.Parse(firstCircle[0]), Y = int.Parse(firstCircle[1])};//First initialize the coordinates of the first cirlce's center
            Point secondCenter = new Point() { X = int.Parse(secondCircle[0]), Y = int.Parse(secondCircle[1]) };// then -||- of the second circle's center.
            Circle c1 = new Circle() { Center = firstCenter ,Radius = double.Parse(firstCircle[2]) };// Add those coordinates to the circle
            Circle c2 = new Circle() { Center = secondCenter, Radius = double.Parse(secondCircle[2]) };// {x} {Y} {r}

            double distance = GetDistanceBetweenCenters(c1, c2);
            //Console.WriteLine(distance);
            if (Intersect(c1,c2) == true)
            {
                Console.WriteLine("Yes");
            }
            else if (Intersect(c1,c2) == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
