using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_21._01._17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2 Complex conditional statements 21.01.17
            /*
            string productName = Console.ReadLine();
            string townName = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price=0;
            switch (townName)
            {
                case "Sofia":
                    {
                        switch (productName)
                        {
                            case "coffee":
                                price = 0.5 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "water":
                                price = 0.8 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "beer":
                                price = 1.2 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "sweets":
                                price = 1.45 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "peanuts":
                                price = 1.6 * quantity;
                                Console.WriteLine(price);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "Plovdiv":
                    {
                        switch (productName)
                        {
                            case "coffee":
                                price = 0.4 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "water":
                                price = 0.7 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "beer":
                                price = 1.15 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "sweets":
                                price = 1.30 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "peanuts":
                                price = 1.5 * quantity;
                                Console.WriteLine(price);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "Varna":
                    {
                        switch (productName)
                        {
                            case "coffee":
                                price = 0.45 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "water":
                                price = 0.7 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "beer":
                                price = 1.1 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "sweets":
                                price = 1.35 * quantity;
                                Console.WriteLine(price);
                                break;
                            case "peanuts":
                                price = 1.55 * quantity;
                                Console.WriteLine(price);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }*/

            //Problem 10
            /*
            string animalType = Console.ReadLine();
            switch (animalType)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
                    
            }*/

            //Problem 11
            /*
            string projectionType = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());
            double income = 0;
            switch (projectionType)
            {
                case "Premiere":
                    {
                        income = (numberOfRows * numberOfColumns) * 12.00;
                        Console.WriteLine("{0:f2}",income);
                    }
                    break;
                case "Normal":
                    {
                        income = (numberOfRows * numberOfColumns) * 7.5;
                        Console.WriteLine("{0:f2}",income);
                    }
                    break;
                case "Discount":
                    {
                        income = (numberOfRows * numberOfColumns) * 5.00;
                        Console.WriteLine("{0:f2}",income);
                    }
                    break;
                default:
                    break;
            }*/

            //Problem 7
            /*
            string fruitName = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price=0;
            switch (dayOfWeek)
            {
                case "Monday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.5;
                                Console.WriteLine("{0:f2}",price);
                                break;
                            case "apple":
                                price = 1.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.45 * quantity;
                                Console.WriteLine("{0:f2}",price);
                                break;
                            case "kiwi":
                                price = 2.7 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.5 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 3.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Tuesday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.5;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "apple":
                                price = 1.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.45 * quantity;
                                Console.WriteLine("{0:f2}",price);
                                break;
                            case "kiwi":
                                price = 2.7 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.5 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 3.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Wednesday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.5;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "apple":
                                price = 1.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.45 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "kiwi":
                                price = 2.7 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.5 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 3.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Thursday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.5;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "apple":
                                price = 1.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.45 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "kiwi":
                                price = 2.7 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.5 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 3.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Friday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.5;
                                Console.WriteLine("{0:f2}",price);
                                break;
                            case "apple":
                                price = 1.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.45 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "kiwi":
                                price = 2.7 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.5 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 3.85 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Saturday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.7;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "apple":
                                price = 1.25 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.9 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.6 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "kiwi":
                                price = 3.0 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.6 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 4.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;
                case "Sunday":
                    {
                        switch (fruitName)
                        {
                            case "banana":
                                price = quantity * 2.7;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "apple":
                                price = 1.25 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "orange":
                                price = 0.9 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapefruit":
                                price = 1.6 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "kiwi":
                                price = 3.0 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "pineapple":
                                price = 5.6 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            case "grapes":
                                price = 4.2 * quantity;
                                Console.WriteLine("{0:f2}", price);
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }*/

            //Problem 12 - Stav's solution
            /*
            string yearType = Console.ReadLine();
            int holidaysInYear = int.Parse(Console.ReadLine());
            int weekednsInHomeTown = int.Parse(Console.ReadLine());

            double holidayVolleyBallDays = 2 * holidaysInYear / 3.0; // 2.0*holidaysInYear*3.0; --> also allowed
            int weekendsInSofia = 48 - weekednsInHomeTown;
            double nonWorkingWeekendsInSofia = 3.0 * weekendsInSofia / 4.0;
            double volleyBallWeekednsInSofia = nonWorkingWeekendsInSofia / 2.0;

            int volleyballDaysInHomeTown = weekednsInHomeTown ;

            double totalVolleyBallDaysInYear = holidayVolleyBallDays + volleyBallWeekednsInSofia + volleyballDaysInHomeTown;

            if (yearType=="leap")
            {
                totalVolleyBallDaysInYear *= 1.15;
            }
            Console.WriteLine((int)totalVolleyBallDaysInYear);
            */
            // Problem 6 - Slav's solution
            /*
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool horizontalBorder = (x1 <= x && x <= x2) && (y == 1 || y == y2);
            bool verticalBorder = (y1 <= y && y <= y2) && (x == x1 || x == x2);
            if (horizontalBorder || verticalBorder)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside/Outside");
            }*/

            
            

        }
    }
}
