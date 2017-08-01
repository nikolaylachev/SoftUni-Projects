using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            double radious;
            double height;
            double volume = 0.0D;
            double bestVolume = 0.0D;
            string model = string.Empty;
            string bestModel = string.Empty;

            model = Console.ReadLine();
            radious = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            volume = Math.PI * Math.Pow(radious, 2) * height;
            bestModel = model;
            bestVolume = volume;
            for (byte i = 1; i <= n-1; i++)
            {
                model = Console.ReadLine();
                radious = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radious, 2) * height;
                if (bestVolume < volume)
                {
                    bestVolume = volume;
                    bestModel = model;
                }

            }
            Console.WriteLine(bestModel);
        }
    }
}
