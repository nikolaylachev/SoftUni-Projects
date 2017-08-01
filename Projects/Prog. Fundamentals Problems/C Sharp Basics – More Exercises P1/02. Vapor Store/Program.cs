using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double copyOfcurrentBalance = currentBalance;// Holds the original value of currentBalance for the remaing money part.
            string command;
            double totalSpending = 0.0D;
            double priceOfGame = 0.0D;
            do
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "OutFall 4":
                        {
                            priceOfGame = 39.99D;
                            if (currentBalance >= priceOfGame)
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= priceOfGame;
                                totalSpending += priceOfGame;
                            }
                           else if (currentBalance < priceOfGame)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            if (currentBalance <= 0.00D)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                        }
                        break;
                    case "CS: OG":
                        {
                            priceOfGame = 15.99D;
                            if (currentBalance >= priceOfGame)
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= priceOfGame;
                                totalSpending += priceOfGame;
                            }
                            else if (currentBalance < priceOfGame)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            if (currentBalance <= 0.00D)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                        }
                        break;
                    case "Zplinter Zell":
                        {
                            priceOfGame = 19.99D;
                            if (currentBalance >= priceOfGame)
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= priceOfGame;
                                totalSpending += priceOfGame;
                            }
                            else if (currentBalance < priceOfGame)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                             if (currentBalance <= 0.00D)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                        }
                        break;
                    case "Honored 2":
                        {
                            priceOfGame = 59.99D;
                            if (currentBalance >= priceOfGame)
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= priceOfGame;
                                totalSpending += priceOfGame;
                            }
                            else if (currentBalance < priceOfGame)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                             if (currentBalance <= 0.00D)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                        }
                        break;
                    case "RoverWatch":
                        {
                            priceOfGame = 29.99D;
                            if (currentBalance >= priceOfGame)
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= priceOfGame;
                                totalSpending += priceOfGame;
                            }
                            else if (currentBalance < priceOfGame)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                             if (currentBalance <= 0.00D)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        {
                            priceOfGame = 39.99D;
                            if (currentBalance >= priceOfGame)
                            {
                                Console.WriteLine($"Bought {command}");
                                currentBalance -= priceOfGame;
                                totalSpending += priceOfGame;
                            }
                           else if (currentBalance < priceOfGame)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            if (currentBalance <= 0.00D)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }

                        }
                        break;
                    default:
                        {
                            if (command != "Game Time")
                            {
                                Console.WriteLine("Not Found"); 
                            }
                            if (command == "Game Time")
                            {
                                break;
                            }
                        }
                        break;
                }

            } while ((currentBalance > 0.00D) && (command != "Game Time"));

            if (currentBalance >= 0.00D)
            {
                Console.WriteLine($"Total spent: ${totalSpending:f2}. Remaining: ${(copyOfcurrentBalance-totalSpending):f2}"); 
            }
        }
    }
}
