using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_04._02._17
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[2*size];
            int[] sumsArray = new int [size];
            int[] differences = new int[size - 1];
            int sumOfSums = 0,i,j;
            int equalCounter = 1, notEqualCounter=0;

            for ( i = 0; i < 2*size; i++)//Inputting the numbers.
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (  i = 1,j = 0; j < size; i+=2,j++)//Finding the sum of each pair.
            {
                sumsArray[j] = numbers[i] + numbers[i - 1];//The array with the sums!
                //sumOfSums += sumsArray[j];
               
            }
            for ( i = 1; i < size; i++)//Checking if all of the array elements are equal or not.
            {
                if (sumsArray[i]==sumsArray[i-1])
                {
                    equalCounter++;
                }
                else
                {
                    notEqualCounter++;
                }
            }

            if (equalCounter == size)
            {
                Console.WriteLine("Yes, value={0}", sumsArray[0]);
            }
            else if (notEqualCounter > 0)
            {
                for (i = 1, j = 0; j < size - 1; i++, j++)//For the differences array
                {

                    if (sumsArray[i] > 0)
                    {
                        differences[j] = sumsArray[i] - sumsArray[i - 1];
                    }
                    else
                    {
                        differences[j] = (sumsArray[i] * -1) + sumsArray[i - 1];
                    }
                }

                Console.WriteLine("No, maxdiff={0}",differences.Max());
            }
        }
    }
}
