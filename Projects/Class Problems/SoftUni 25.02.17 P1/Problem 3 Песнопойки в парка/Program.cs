using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Песнопойки_в_парка
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfBirdsInThePark = double.Parse(Console.ReadLine());
            double numberOfAllFeathers = double.Parse(Console.ReadLine());
            if (numberOfBirdsInThePark == 0 && numberOfAllFeathers == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                double averageNumberOfFeathers = numberOfAllFeathers / numberOfBirdsInThePark;
                //Console.WriteLine(averageNumberOfFeathers);
                if (numberOfBirdsInThePark % 2 == 0)
                {
                    Console.WriteLine("{0:f4}", (averageNumberOfFeathers * 123123123123));
                }
                else if (numberOfBirdsInThePark % 2 == 1)
                {
                    Console.WriteLine("{0:f4}", (averageNumberOfFeathers / 317));
                } 
            }
            
        }
    }
}
