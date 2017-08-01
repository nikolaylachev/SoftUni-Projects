using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public double CalcDistance(Point p1, Point p2)
            {
                double distanceBetweenTwoPoints = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
                return distanceBetweenTwoPoints; 
            }

            //public double FindSmallestDistance(Point[] p1)
            //{

            //}
        }

        static void Main(string[] args)
        {
            //List<int> firstPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> secondPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //Point p1 = new Point() { X = firstPointCoordinates[0], Y = firstPointCoordinates[1] };
            //Point p2 = new Point() { X = secondPointCoordinates[0], Y = secondPointCoordinates[1] };
            //Point p3 = new Point() { X = 0, Y = 0 };
            //double distance = p3.CalcDistance(p1, p2);
            //Console.WriteLine($"{distance:f3}");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

            }

        }
    }
}
