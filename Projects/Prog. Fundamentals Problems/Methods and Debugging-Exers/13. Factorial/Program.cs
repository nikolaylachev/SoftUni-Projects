using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _13.Factorial
{
    class Program
    {
        static BigInteger Factorial (BigInteger number)
        {
            BigInteger factorial = 1;
            for (BigInteger i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void FactorialTrailingZeroes(BigInteger number)
        {
            BigInteger factorial = Factorial(number);
            int counter = 0;
            BigInteger lastDigit = 0 ;
            while (lastDigit == 0)
            {
                lastDigit = factorial % 10;
                counter++;
                factorial /= 10;
            }
            if (number > 0)
            {
                Console.WriteLine(counter - 1); 
            }
            else if (number == 0)
            {
                Console.WriteLine("0");
            }
        }
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            //Console.WriteLine(Factorial(number));
            FactorialTrailingZeroes(number);
        }
    }
}
