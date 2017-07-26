using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double a = Math.Abs(x2 - x3);
            double h= Math.Abs(y1-y2);
            //Console.WriteLine("a={0} h={1}",a,h);
            double area = (a * h) / 2;
            Console.WriteLine(area);
        }
    }
}
