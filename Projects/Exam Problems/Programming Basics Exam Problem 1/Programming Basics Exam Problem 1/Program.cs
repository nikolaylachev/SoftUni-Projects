using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtOfSide = double.Parse(Console.ReadLine());
            double heightOfHouse = double.Parse(Console.ReadLine());

            double twoSides = (lenghtOfSide * (lenghtOfSide / 2)) * 2;
            double square = ((lenghtOfSide / 2) * (lenghtOfSide / 2));
            double triangle = ((lenghtOfSide / 2) * (heightOfHouse - (lenghtOfSide) / 2)) / 2;
            double backSide = (square + triangle);
            double entry = (lenghtOfSide / 5) * (lenghtOfSide / 5);
            double frontSide = backSide - entry;
            double total = (twoSides + backSide + frontSide);
            double roof = lenghtOfSide * (lenghtOfSide / 2) * 2;
            double greenPaint = total / 3.0D;
            double redPaint = roof / 5.0D;

            Console.WriteLine("{0:f2}",greenPaint);
            Console.WriteLine("{0:f2}",redPaint);
        }
    }
}
