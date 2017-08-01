using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _07.Primes_in_given_range
{
    class Program
    {
        static void FindPrimesInRange (int startNumber, int endNumber)
        {
            int primeCounter = 0;
            int maxPrimeInGivenRange = 0;
            string printingPrimeNumbersInRange = string.Empty;
            for (int number = startNumber; number <= endNumber; number++)
            {
               // maxPrimeInGivenRange = number; 
                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0) // If number % 1 == 0 && number % number == 0 -> It is prime.
                    {
                        primeCounter++;
                    }
                }
                if (primeCounter == 2)// The number is prime if it can be divided on itself or 1 ONLY!!! That is why primeCounter must be equal to 2.
                {
                    if (number > maxPrimeInGivenRange)//Finding max prime number (not needed).
                    {
                        maxPrimeInGivenRange = number;
                    }
                    printingPrimeNumbersInRange += ($"{number}, ");
                    //Console.Write($"{number},"); 
                    
                }
                primeCounter = 0;
            }
            //Using StringBuilder to remove the last element of the string (The comma after the last element).
            var aStringBuilder = new StringBuilder(printingPrimeNumbersInRange);
            aStringBuilder.Remove(printingPrimeNumbersInRange.Length-2 , 1);
            aStringBuilder.Insert(printingPrimeNumbersInRange.Length - 2 , " ");

            printingPrimeNumbersInRange = aStringBuilder.ToString();
            Console.WriteLine(printingPrimeNumbersInRange);

            //Console.WriteLine(maxPrimeInGivenRange);
        }

        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            FindPrimesInRange(startNumber, endNumber);
        }
    }
}
