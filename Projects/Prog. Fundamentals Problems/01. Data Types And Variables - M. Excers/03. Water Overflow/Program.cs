using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            short sum = 0;
            for (int i = 1; i <= n; i++)
            {
                short quantitiesOfWater = short.Parse(Console.ReadLine());
                sum += quantitiesOfWater;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantitiesOfWater;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
