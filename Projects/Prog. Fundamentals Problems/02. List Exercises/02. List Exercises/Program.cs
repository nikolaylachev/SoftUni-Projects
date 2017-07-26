using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.List_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long equalPairsCounter = 0L;
            long bestCounter = 0L;
            long currentElement = numbers[0];
            long bestElement = currentElement;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i==0)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        equalPairsCounter++;
                    }
                    if (numbers[i] != numbers[i+1])
                    {
                        equalPairsCounter++;
                        if (equalPairsCounter > bestCounter)
                        {
                            bestCounter = equalPairsCounter;
                            bestElement = currentElement;
                            equalPairsCounter = 0;
                        }
                    }
                   
                    
                    
                }
                if ( i > 0 && i < numbers.Count-1)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        equalPairsCounter++;
                        currentElement = numbers[i];
                    }
                    else if ((i>0) && numbers[i] != numbers[i+1])
                    {
                        if ((i-1 >= 0) && (numbers[i] == numbers[i-1]))
                        {
                            equalPairsCounter++;
                            currentElement = numbers[i];
                        }
                        if (equalPairsCounter > bestCounter)
                        {
                            bestCounter = equalPairsCounter;
                            bestElement = currentElement;
                            
                        }
                        equalPairsCounter = 0;
                    }
                }
                
                if (i == numbers.Count-1)
                {
                    if (numbers[i] == numbers[i-1])
                    {
                        equalPairsCounter++;
                    }
                    if (equalPairsCounter > bestCounter)
                    {
                        bestCounter = equalPairsCounter;
                        bestElement = currentElement;
                        equalPairsCounter = 0;
                    }
                }
               
            }
            for (int i = 1; i <= bestCounter; i++)
            {
                Console.Write($"{bestElement} "); 
            }
        }
    }
}
