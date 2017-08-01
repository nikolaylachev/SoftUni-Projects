using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Hotel_Room_21._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOFMonth = Console.ReadLine();
            double numberOFNights = int.Parse(Console.ReadLine());

            double studio;
            double apartement;
            
                switch (nameOFMonth)
                { case"May":
                    {
                        if (numberOFNights > 7 && numberOFNights<=14)
                        {
                            studio = (50 - (50 * 0.05)) * numberOFNights;
                            apartement = 65 * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.",apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        else if (numberOFNights > 14)
                        {
                            studio = (50 - (50 * 0.3)) * numberOFNights;
                            apartement = (65 - (65 * 0.1)) * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                    }
                        break;
                    case "June":
                    {
                        if (numberOFNights > 7 && numberOFNights<=14)
                        {
                            studio = 75.2 * numberOFNights;
                            apartement = 68.7 * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        else if (numberOFNights > 14)
                        {
                            studio = (75.2 - (75.2 * 0.2)) * numberOFNights;
                            apartement = (68.7-(68.7*0.1)) * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        
                    }
                    break;
                    case "July":
                    {
                        if (numberOFNights > 7 && numberOFNights <= 14)
                        {
                            studio = 76 * numberOFNights;
                            apartement = 77 * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        else if (numberOFNights > 14)
                        {
                            studio = 76 * numberOFNights;
                            apartement = (77-(77*0.1)) * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                    }
                        break;
                    case "August":
                    {
                        if (numberOFNights > 7 && numberOFNights <= 14)
                        {
                            studio = 76 * numberOFNights;
                            apartement = 77 * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        else if (numberOFNights > 14)
                        {
                            studio = 76 * numberOFNights;
                            apartement = (77-(77*0.1)) * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                    }
                        break;
                    case "September":
                    {
                        if (numberOFNights > 7 && numberOFNights <= 14)
                        {
                            studio = 75.2 * numberOFNights;
                            apartement = 68.7 * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        else if (numberOFNights > 14)
                        {
                            studio = (75.2 - (75.2 * 0.2)) * numberOFNights;
                            apartement = (68.7-(68.7*0.1)) * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                    }
                        break;
                    case "October":
                    {
                        if (numberOFNights > 7 && numberOFNights <= 14)
                        {
                            studio = (50 - (50 * 0.05)) * numberOFNights;
                            apartement = 65 * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                        else if (numberOFNights > 14)
                        {
                            studio = (50 - (50 * 0.3)) * numberOFNights;
                            apartement = (65 - (65 * 0.1)) * numberOFNights;
                            Console.WriteLine("Apartment: {0:f2} lv.", apartement);
                            Console.WriteLine("Studio: {0:f2} lv.", studio);
                        }
                    }
                    break;
                    default:
                        break;
                }
            
            
        }
    }
}
