using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            int difference = 0;

            if (first > second)//10-f 5-s
            {
                if (point >= second && point <= first)//p>=5 && p<=10
                {
                    Console.WriteLine("in");
                    if (Math.Abs(first-point) < Math.Abs(second-point))
                    {
                        Console.WriteLine(Math.Abs(first-point));
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(second-point));
                    }
                   
                }
                 else if (point < second || point > first)//p<5 && p>10
                {
                    Console.WriteLine("out");
                    if (point>first && point>second)
                    {
                        Console.WriteLine(Math.Abs(first-point));
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(second-point));
                    }
                  
                }
            }

             else if (first < second)// 8-f 10-s
            {
                if (point>=first && point<=second)//p>=8 && p<=10
                {
                    Console.WriteLine("in");
                    if (Math.Abs(first-point) < Math.Abs(second-point))
                    {
                        Console.WriteLine(Math.Abs(first-point));
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(second-point));
                    }
                }
                 else if (point<first || point>second)//p<8 && p>10
                {
                    Console.WriteLine("out");
                    if (point < first && point < second )
                    {
                        Console.WriteLine(Math.Abs(first-point));
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(second-point));
                    }
                }
            }
        }
    }
}
