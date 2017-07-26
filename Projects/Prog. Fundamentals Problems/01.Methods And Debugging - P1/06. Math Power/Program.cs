using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static double Power(double number, int power)
        {
            double newNumber = 1.0;
            for (int i = 1; i <= power; i++)
            {
                newNumber *= number ;
            }
            return newNumber;
        }
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(number,power));
        }
    }
}
