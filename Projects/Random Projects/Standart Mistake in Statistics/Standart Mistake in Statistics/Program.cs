using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_Mistake_in_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            int[] x = new int[size];
            double sum = 0.0D;
            double average = 0.0D;

            for (int i = 0; i < size; i++)
            {
                Console.Write("x[{0}]= ", i);
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                sum += x[i];
            }

            average = sum / size;
            double standartDeviation = 0.0D;
            double sumOfStandartDeviation = 0.0D;

            for (int i = 0; i < size; i++)
            {
                sumOfStandartDeviation += Math.Pow((x[i] - average),2);
            }

            standartDeviation = Math.Sqrt(sumOfStandartDeviation / size);
            Console.WriteLine("Average = {0:f2}", average);
            Console.WriteLine("Standart Deviation = {0:f2}", Math.Round(standartDeviation,2));


        }
    }
}
