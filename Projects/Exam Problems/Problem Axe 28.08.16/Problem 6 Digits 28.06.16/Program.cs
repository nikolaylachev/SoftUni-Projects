using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_Digits_28._06._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 100;
            int secondDigit = number % 100 / 10;
            int thirdDigit = number % 10;
            for (int row =1 ; row <= firstDigit+secondDigit; row++)
            {
                for (int col = 1; col <= firstDigit+thirdDigit; col++)
                {
                    if (number%3==0)//%5
                    {
                        number -= secondDigit;//firstDigit
                    }
                    else if (number%5==0)//%3
                    {
                        number -= firstDigit;//secondDigit
                    }
                    else if (number%3!=0 && number%5!=0)
                    {
                        number += thirdDigit;
                    }
                    Console.Write("{0} ",number);
                }
                Console.WriteLine();
            }

        }
    }
}
