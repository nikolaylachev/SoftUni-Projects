using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_number
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else if (number % 2 == 1 || number % 2 == -1)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("The number is: {0}", Math.Abs(number));
                        break;
                    }
                    else if (number >= 0)
                    {
                        Console.WriteLine($"The number is: {number}");
                        break;
                    }
                    break;
                }

            } while (true);
        }
    }
}
