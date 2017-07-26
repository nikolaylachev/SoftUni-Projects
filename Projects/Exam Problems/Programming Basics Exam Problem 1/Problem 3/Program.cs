using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0.00D;
            if (budget<=100)
            {
                Console.WriteLine("Economy class");
                if (season=="Summer")
                {
                    price = 0.35 * budget;
                    Console.WriteLine("Cabrio - {0:f2}",price);
                }
                else if (season == "Winter")
                {
                    price = 0.65 * budget;
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
            }

            if (budget > 100 && budget<=500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    price = 0.45 * budget;
                    Console.WriteLine("Cabrio - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = 0.80 * budget;
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
            }

            if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                if (season == "Summer")
                {
                    price = 0.9 * budget;
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = 0.9 * budget;
                    Console.WriteLine("Jeep - {0:f2}", price);
                }
            }
        }
    }
}
