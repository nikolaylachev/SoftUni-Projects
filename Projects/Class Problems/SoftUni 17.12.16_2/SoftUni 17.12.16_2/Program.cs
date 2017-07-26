using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_17._12._16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.ReadLine());--->Prints whatever you insert as an input!
            decimal sum = decimal.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();
            decimal[] currencies = { 1.79549M, 1.95583M, 2.53405M };//USD EUR GBP
            switch (convertFrom)
            {
                case "BGN":
                    if (convertTo=="USD")
                    {
                        Console.WriteLine(Math.Round(sum/currencies[0],2));
                    }
                    if (convertTo=="EUR")
                    {
                        Console.WriteLine(Math.Round(sum/currencies[1],2));
                    }
                    if (convertTo == "GBP")
                    {
                        Console.WriteLine(Math.Round(sum/currencies[2],2));
                    }
                    break;

                case "USD":
                    if (convertTo == "BGN" )
                    {
                        Console.WriteLine(Math.Round(sum*currencies[0],2));
                    }
           
                    if (convertTo == "EUR")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[0]/currencies[1],2));
                    }
                    if (convertTo == "GBP")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[0]/currencies[2],2));
                    }
                    break;

                case "EUR":
                    if (convertTo == "BGN")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[1],2));
                    }
                    if (convertTo == "USD")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[1]/currencies[0],2));
                    }
                    if (convertTo == "GBP")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[1]/currencies[2],2));
                    }
                    break;

                case "GBP":
                    if (convertTo == "BGN")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[2],2));
                    }
                    if (convertTo == "USD")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[2]/currencies[0],2));
                    }
                    if (convertTo == "EUR")
                    {
                        Console.WriteLine(Math.Round(sum*currencies[2]/currencies[1],2));
                    }
                    break;

                default:
                    Console.WriteLine("Invalid currency!");
                    break;
            }

        }
    }
}
