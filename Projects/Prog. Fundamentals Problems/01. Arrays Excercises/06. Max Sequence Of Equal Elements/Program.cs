using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int equalPairCounter = 0;
            int bestCounter = 0;
            int currentElement = 0;
            int bestElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length-1)// 0<= i < arr.Length
                {
                    if (arr[i] == arr[i + 1])
                    {
                        equalPairCounter++;
                        currentElement = arr[i]; //Added later!!!
                    }
                    else if (arr[i] != arr[i + 1] && i > 0)
                    {
                        if (arr[i] == arr[i - 1] && ((i - 1) >= 0))
                        {
                            equalPairCounter++;
                            currentElement = arr[i];// Added later!!!
                        }
                        if (bestCounter < equalPairCounter)
                        {
                            bestCounter = equalPairCounter;
                            bestElement = currentElement;//Added later!!!
                        }
                        equalPairCounter = 0;
                    } 
                }

                if (i == arr.Length-1) //i == arr.Length-1
                {
                    if (arr[i] == arr[i-1])
                    {
                        equalPairCounter++;
                    }
                }

                if (bestCounter < equalPairCounter)
                {
                    bestCounter = equalPairCounter;
                    bestElement = arr[i]; //Added later!!!
                }
                //equalPairCounter = 0;

            }
            //Console.WriteLine(bestCounter);
            //Console.WriteLine(bestElement);
            //Console.WriteLine($"{bestElement} -> {bestCounter} times.");
            for (int i = 1; i <= bestCounter; i++)
            {
                Console.Write($"{bestElement} ");
            }
        }
    }
}
