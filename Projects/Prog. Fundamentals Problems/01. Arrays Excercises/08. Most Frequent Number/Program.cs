using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int equalsCounter = 0;
            int bestEqualsCounter = 0;
            int currentElement = arr[0];
            int bestElement = currentElement;//= arr[0];
            int[] copyOFArr = arr;

            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}
            //Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        equalsCounter++;
                        currentElement = arr[j];
                    }
                }
                if (equalsCounter > bestEqualsCounter)
                {
                    bestEqualsCounter = equalsCounter;
                    if (bestElement <= currentElement)
                    {
                        bestElement = currentElement;
                    }
                }
                equalsCounter = 0;
            }
            Console.WriteLine(bestElement);
            //if (bestEqualsCounter > 1)
            //{
            //    Console.WriteLine(bestElement); 
            //}
            //else if (bestEqualsCounter == 1)
            //{
            //    Console.WriteLine(bestElement-bestElement);
            //} 
        }
    }
}
