using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int increasingSequenceCounter = 0;
            int bestCounter = 0;
            int currentElementPosition = 0;
            int bestElementPosition = 0;
         
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1) // 0<= i < arr.Length - 1
                {
                    if (arr[i] < arr[i+1])
                    {
                        increasingSequenceCounter++;
                        currentElementPosition = i;
                    }
                    else if (arr[i] >= arr[i+1] && i > 0)
                    {
                        if (arr[i] > arr[i-1] && (i-1) >= 0)
                        {
                            increasingSequenceCounter++;
                            currentElementPosition = i;
                        }
 
                        if (bestCounter < increasingSequenceCounter)
                        {
                            bestCounter = increasingSequenceCounter;
                            bestElementPosition = currentElementPosition;
                        }
                        increasingSequenceCounter = 0;
                    }
                    
                }

                else if (i == arr.Length-1) // i == last element of the array
                {
                    if (arr[i] > arr[i-1])
                    {
                        increasingSequenceCounter++;
                        currentElementPosition = i; 
                    }
                }

                if (bestCounter < increasingSequenceCounter)
                {
                    bestCounter = increasingSequenceCounter;
                    bestElementPosition = currentElementPosition;
                }
            }
            //Console.WriteLine($"best counter = {bestCounter}");
            //Console.WriteLine($"best position = {bestElement}");
            //Console.WriteLine($"fisrt position = {firstElementInSequence}");
            int bestFirstPositionOfLongestSequence = (bestElementPosition - bestCounter) + 1;
            for (int i = bestFirstPositionOfLongestSequence; i <= bestElementPosition; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            
        }
    }
}
