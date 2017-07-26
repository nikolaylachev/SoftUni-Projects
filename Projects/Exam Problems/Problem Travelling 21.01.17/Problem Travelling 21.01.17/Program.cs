using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Travelling_21._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget <= 100)//Bulgaria
            {
                switch (season)
                {
                    case "summer"://Camp
                        {
                            budget *=0.3;
                            Console.WriteLine("Somewhere in Bulgaria");
                            Console.WriteLine("Camp - {0:f2}",budget);
                        }
                        break;
                    case "winter"://Hotel
                        {
                            budget *= 0.7;
                            Console.WriteLine("Somewhere in Bulgaria");
                            Console.WriteLine("Hotel - {0:f2}", budget);
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (budget<=1000)//Balkans
            {
                switch (season)
                {
                    case "summer"://Camp
                        {
                            budget *= 0.4;
                            Console.WriteLine("Somewhere in Balkans");
                            Console.WriteLine("Camp - {0:f2}", budget);
                        }
                        break;
                    case "winter"://Hotel
                        {
                            budget *= 0.8;
                            Console.WriteLine("Somewhere in Balkans");
                            Console.WriteLine("Hotel - {0:f2}", budget);
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (budget>1000)//Europe
            {
                switch (season)
                {
                    case "summer"://Hotel
                        {
                            budget *= 0.9;
                            Console.WriteLine("Somewhere in Europe");
                            Console.WriteLine("Hotel - {0:f2}", budget);
                        }
                        break;
                    case "winter"://Hotel
                        {
                            budget *= 0.9;
                            Console.WriteLine("Somewhere in Europe");
                            Console.WriteLine("Hotel - {0:f2}", budget);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
