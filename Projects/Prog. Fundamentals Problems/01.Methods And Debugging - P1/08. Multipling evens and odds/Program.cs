using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multipling_evens_and_odds
{
    class Program
    {
        static int SumOfEvenAndOddDigits(int number)
        {
            string numberToString = string.Empty;
            if (number < 0)
            {
                number *= -1;
            }
            while (number > 0)
            {
                int lastDigit = number % 10;
                numberToString += lastDigit;
                number /= 10;
            }
            //Console.WriteLine(numberToString);
            int sumOfEvenDigits = 0;
            int sumOfOddDigits = 0;

            for (int i = numberToString.Length-1; i >= 0; i--)
            {
                if (numberToString[i] % 2 == 0)
                {
                    sumOfOddDigits += (int)(numberToString[i] - 48);
                }
                else if (numberToString[i] % 2 != 0)
                {
                    sumOfEvenDigits += (int)(numberToString[i] - 48);
                }
            }

            int total = sumOfEvenDigits * sumOfOddDigits;
            return total;
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfEvenAndOddDigits(number));
            //Console.WriteLine('2'- 48);
        }
    }
}
