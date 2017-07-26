using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, 
                StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"";
            int firstHalfSymbolCounter = 0;
            char firstHalfWinningSymbol = 'a';
            char firstHalfBestSymbol = 'a';
            int firstHalfBestCounter = firstHalfSymbolCounter;
            
            
           
            int secondHalfSymbolCounter = 0;
            int secondHlafBestCounter = firstHalfSymbolCounter;
            char secondHalfWinningSymbol = 'a';
            char secondHalfBestSymbol = 'a';

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    for (int ticketIndex = 0; ticketIndex < tickets[i].Length/2; ticketIndex++)
                    {

                        if (ticketIndex == 0)
                        {
                            if (tickets[i][ticketIndex] == tickets[i][ticketIndex+1])
                            {
                                firstHalfSymbolCounter++;
                                firstHalfWinningSymbol = tickets[i][ticketIndex];
                            }
    
                        }
    
                        else if (ticketIndex > 0 && ticketIndex < tickets[i].Length/2 - 1)
                        {
                            if (tickets[i][ticketIndex] == tickets[i][ticketIndex + 1])
                            {
                                firstHalfSymbolCounter++;
                                firstHalfWinningSymbol = tickets[i][ticketIndex];
                            }
                            else if (tickets[i][ticketIndex] != tickets[i][ticketIndex + 1])
                            {
                                if (tickets[i][ticketIndex] == tickets[i][ticketIndex - 1])
                                {
                                    firstHalfSymbolCounter++;
                                    firstHalfWinningSymbol = tickets[i][ticketIndex];
                                }

                                if (firstHalfBestCounter < firstHalfSymbolCounter)
                                {
                                    firstHalfBestCounter = firstHalfSymbolCounter;
                                    firstHalfBestSymbol = firstHalfWinningSymbol;
                                    firstHalfSymbolCounter = 0;
                                    firstHalfWinningSymbol = 'a';
                                   
                                }
                            }
                        }

                        else if (ticketIndex == tickets[i].Length/2 - 1)
                        {
                            if(tickets[i][ticketIndex] == tickets[i][ticketIndex - 1])
                            {
                                firstHalfSymbolCounter++;
                                firstHalfWinningSymbol = tickets[i][ticketIndex];
                            }

                            if (firstHalfBestCounter < firstHalfSymbolCounter)
                            {
                                firstHalfBestCounter = firstHalfSymbolCounter;
                                firstHalfBestSymbol = firstHalfWinningSymbol;
                                firstHalfSymbolCounter = 0;
                                firstHalfWinningSymbol = 'a';

                            }
                        }

                    }

                    for (int ticketIndex = tickets[i].Length/2; ticketIndex < tickets[i].Length; ticketIndex++)
                    {
                        if (ticketIndex == tickets[i].Length/2)
                        {
                            if (tickets[i][ticketIndex] == tickets[i][ticketIndex + 1])
                            {
                                secondHalfSymbolCounter++;
                                secondHalfWinningSymbol = tickets[i][ticketIndex]; 
                            }
                        }
                        else if (ticketIndex > tickets[i].Length/2 && ticketIndex < tickets[i].Length-1)
                        {
                            if (tickets[i][ticketIndex] == tickets[i][ticketIndex + 1])
                            {
                                secondHalfSymbolCounter++;
                                secondHalfWinningSymbol = tickets[i][ticketIndex];
                            }
                            else if (tickets[i][ticketIndex] != tickets[i][ticketIndex + 1])
                            {
                                if (tickets[i][ticketIndex] == tickets[i][ticketIndex - 1])
                                {
                                    secondHalfSymbolCounter++;
                                    secondHalfWinningSymbol = tickets[i][ticketIndex];
                                }

                                if (secondHlafBestCounter < secondHalfSymbolCounter)
                                {
                                    secondHlafBestCounter = secondHalfSymbolCounter;
                                    secondHalfBestSymbol = secondHalfWinningSymbol;
                                    secondHalfSymbolCounter = 0;
                                    secondHalfWinningSymbol = 'a';

                                }
                            }
                        }
                        else if (ticketIndex == tickets[i].Length - 1)
                        {
                            if (tickets[i][ticketIndex] == tickets[i][ticketIndex - 1])
                            {
                                secondHalfSymbolCounter++;
                                secondHalfWinningSymbol = tickets[i][ticketIndex];
                            }

                            if (secondHlafBestCounter < secondHalfSymbolCounter)
                            {
                                secondHlafBestCounter = secondHalfSymbolCounter;
                                secondHalfBestSymbol = secondHalfWinningSymbol;
                                secondHalfSymbolCounter = 0;
                                secondHalfWinningSymbol = 'a'; 
                            }
                        }
                    }

                    if (firstHalfBestCounter >=6 && firstHalfBestCounter <= 9
                        && secondHlafBestCounter >=6 && secondHlafBestCounter <= 9
                        && firstHalfBestSymbol == secondHalfBestSymbol)
                    {
                        Console.WriteLine(@"ticket ""{0}"" - {1}{2}",tickets[i],firstHalfBestCounter,firstHalfBestSymbol);
                    }
                    else if (firstHalfBestCounter == 10 && secondHlafBestCounter == 10
                        && firstHalfBestSymbol == secondHalfBestSymbol)
                    {
                        Console.WriteLine(@"ticket ""{0}"" - {1}{2} Jackpot!", tickets[i], firstHalfBestCounter, firstHalfBestSymbol);
                    }
                    else
                    {
                        Console.WriteLine(@"ticket ""{0}"" - no match",tickets[i]);
                    }

                    firstHalfSymbolCounter = 0;
                    firstHalfWinningSymbol = 'a';
                    secondHalfSymbolCounter = 0;
                    secondHalfWinningSymbol = 'a';

                    firstHalfBestCounter = 0;
                    firstHalfBestSymbol = 'a';
                    secondHlafBestCounter = 0;
                    secondHalfBestSymbol = 'a';
                }
                else if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    firstHalfSymbolCounter = 0;
                    firstHalfWinningSymbol = 'a';
                    secondHalfSymbolCounter = 0;
                    secondHalfWinningSymbol = 'a';
                }
            }
        }
    }
}
