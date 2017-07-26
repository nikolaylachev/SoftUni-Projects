using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Project
{
    class Program
    {
        static double Power(double x = 0, double n = 0)
        {
            double power = 1;
            for (int i = 1; i <= n; i++)
            {
                power *= x;
            }
            return power;
        }

        static void Root(double number, double numerator, double denominator)
        {
            double powerInDouble = numerator / denominator;
            Console.WriteLine(Power(number,powerInDouble));
        }
        
        static void Main(string[] args)
        {

            /*double sum = 0.0D;
            Console.Write("Въведете размера на масива: ");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("numbers[{0}]= ",i);
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("За средно аритметично->1, За средно хармонично->2: ");
            sbyte answer = sbyte.Parse(Console.ReadLine());

            if (answer == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine("{0:f2}", (sum / n));
            }
            else if (answer == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += (1 / numbers[i]);
                }
                Console.WriteLine("{0:f2}", (n / sum));
            }*/
            Console.Write("5^4= ");
            Console.WriteLine(Power(1,4));// 5^4=625
            Root(4,1,4);
        }
    }
}
