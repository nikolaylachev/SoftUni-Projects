using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int bestIn = n, bestOut = n;
            int counterOfCombinations = 0;

            for (int outside = n; outside <= m; outside++)
            {
                for (int inside = n; inside <= m; inside++)
                {
                    if (outside+inside == magicNumber)
                    {
                        counterOfCombinations += 0;
                        if ((bestOut < outside))
                        {
                            bestOut = outside;
                            bestIn = inside;
                        }
                    }
                    else
                    {
                        counterOfCombinations++;
                    }
                }
            }
            if (counterOfCombinations < Math.Pow(((m-n)+1),2))
            {
                Console.WriteLine($"Number found! {bestOut} + {bestIn} = {magicNumber}"); 
            }

            else if(counterOfCombinations == Math.Pow(((m-n)+1),2))
            {
                Console.WriteLine($"{counterOfCombinations} combinations - neither equals {magicNumber}"); 
            }
        }
    }
}
