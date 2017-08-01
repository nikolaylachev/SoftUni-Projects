using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        // !!! Not my algorithm. Taken from: https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
        public static bool isPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        // My algorithm.
        /*static void PrimeCheck(long n)
        {
            long number = n;
            long primeCounter = 0;
            for (long i = 1; i <= n; i++)
            {
                if (number % i == 0 )
                {
                    primeCounter++;
                }

            }
            if (primeCounter == 2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }*/

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}
