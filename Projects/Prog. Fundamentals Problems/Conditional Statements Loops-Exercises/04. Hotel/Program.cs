using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceOfStudio = 0.00D;
            double priceOfDouble = 0.00D;
            double priceOfSuite = 0.00D;

            double totalPriceOfStudio = 0.00D, totalPriceOfDouble = 0.00D, totalPriceOfSuite = 0.00D ;
            switch (month)
            {
                case "May":
                    {
                        priceOfStudio = 50.00D;
                        priceOfDouble = 65.00D;
                        priceOfSuite = 75.00D;
                        if (numberOfNights > 7)
                        {
                            priceOfStudio *= 0.95D;
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 7)
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                case "June":
                    {
                        priceOfStudio = 60.00D;
                        priceOfDouble = 72.00D;
                        priceOfSuite = 82.00D;
                        if (numberOfNights > 14)
                        {
                            priceOfDouble *= 0.90D;
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 14)
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                case "July":
                    {
                        priceOfStudio = 68.00D;
                        priceOfDouble = 77.00D;
                        priceOfSuite = 89.00D;
                        if (numberOfNights > 14)
                        {
                            priceOfSuite *= 0.85D;
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 14)
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                case "August":
                    {
                        priceOfStudio = 68.00D;
                        priceOfDouble = 77.00D;
                        priceOfSuite = 89.00D;
                        if (numberOfNights > 14)
                        {
                            priceOfSuite *= 0.85D;
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 14)
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                case "September":
                    {
                        priceOfStudio = 60.00D;
                        priceOfDouble = 72.00D;
                        priceOfSuite = 82.00D;
                        if (numberOfNights > 14)
                        {
                            priceOfDouble *= 0.90D;
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 14 && numberOfNights > 7)
                        {
                            totalPriceOfStudio = (priceOfStudio * numberOfNights)-priceOfStudio;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                       
                        else
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                case "October":
                    {
                        priceOfStudio = 50.00D;
                        priceOfDouble = 65.00D;
                        priceOfSuite = 75.00D;
                        if (numberOfNights > 7)
                        {
                            priceOfStudio *= 0.95;
                            totalPriceOfStudio = (priceOfStudio * numberOfNights)-priceOfStudio;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 7)
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                       
                        else
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                case "December":
                    {
                        priceOfStudio = 68.00D;
                        priceOfDouble = 77.00D;
                        priceOfSuite = 89.00D;
                        if (numberOfNights > 14)
                        {
                            priceOfSuite *= 0.85D;
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                        else if (numberOfNights <= 14)
                        {
                            totalPriceOfStudio = priceOfStudio * numberOfNights;
                            totalPriceOfDouble = priceOfDouble * numberOfNights;
                            totalPriceOfSuite = priceOfSuite * numberOfNights;
                            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
                            Console.WriteLine($"Double: {totalPriceOfDouble:f2} lv.");
                            Console.WriteLine($"Suite: {totalPriceOfSuite:f2} lv.");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
