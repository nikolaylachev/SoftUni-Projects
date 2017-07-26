using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static long FindNumberOfGoldCharacters(string command)
        {
            long counterOfGoldCharacters = 0L;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '$')
                {
                    counterOfGoldCharacters++;
                }
            }
            return counterOfGoldCharacters;
        }

        static long FindNumberOfJewelsCharacters(string command)
        {
            long counterOfJewelsCharacters = 0L;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '%')
                {
                    counterOfJewelsCharacters++;
                }
            }
            return counterOfJewelsCharacters;
        }
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();// prices[0] -> jewels % ; prices[1] -> gold $
            long priceOfJewels = prices[0];
            long priceOfGold = prices[1];
            long totalEarnings = 0L;
            string command;//string.Empty;
            string stringToLong = string.Empty;
            long heistExpenses = 0L;
            long totalHeistExpenses = 0L;
            //long heistExpenses;
            do
            {
                command =  Console.ReadLine();
                if (command != "Jail Time")
                {
                    for (int i = 0; i < command.Length; i++)
                    {
                        
                        if (command[i] >= '0' && command[i] <= '9')
                        {
                            stringToLong += command[i];
                        }
                    }
                    heistExpenses = Convert.ToInt64(stringToLong);
                    totalHeistExpenses += heistExpenses;
                    stringToLong = string.Empty;

                    totalEarnings += (priceOfGold * FindNumberOfGoldCharacters(command)) + (priceOfJewels * FindNumberOfJewelsCharacters(command));
                }
                else
                {
                    break;
                }


            } while (command != "Jail Time");
            //Console.WriteLine(totalEarnings);
            //Console.WriteLine(totalHeistExpenses);
            //Console.WriteLine(totalEarnings - totalHeistExpenses);
            if (totalEarnings >= totalHeistExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings-totalHeistExpenses}.");
            }
            else if (totalEarnings < totalHeistExpenses)
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalHeistExpenses-totalEarnings)}.");
            }

        }
    }
}
