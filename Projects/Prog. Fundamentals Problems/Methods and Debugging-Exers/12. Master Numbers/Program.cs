using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _12.Master_Numbers
{
    class Program
    {
        static string ReverseString (string s1)
        {
            string reversedString = string.Empty;
            for (int i = s1.Length-1; i >= 0; i--)
            {
                reversedString += s1[i];
            }
            return reversedString;
        }
        static bool IsPolindome (int number)
        {
           // string polindromeNumber = string.Empty;
            string polindromeNumber = number.ToString();
            bool isPolindome = false;
            if (polindromeNumber.Length == 1)
            {
                isPolindome = true;
                return isPolindome;
            }
            else if (polindromeNumber.Length > 1)
            {
                string firstHalf = string.Empty;
                string secondHalf = string.Empty;
                if (polindromeNumber.Length % 2 == 0)
                {
                    for (int i = 0; i < (polindromeNumber.Length/2); i++)
                    {
                        firstHalf += polindromeNumber[i];
                    }

                    for (int i = polindromeNumber.Length / 2; i < polindromeNumber.Length; i++)
                    {
                        secondHalf += polindromeNumber[i];
                    }

                    secondHalf = ReverseString(secondHalf);
                    if (firstHalf == secondHalf)
                    {
                        isPolindome = true;
                        return isPolindome;
                    }
                    else
                    {
                        isPolindome = false;
                        return isPolindome;
                    }
                }
                else if (polindromeNumber.Length % 2 != 0)// 5/2 = 2 -> 3
                {
                    for (int i = 0; i < (polindromeNumber.Length/2); i++)
                    {
                        firstHalf += polindromeNumber[i];
                    }

                    for (int i = (polindromeNumber.Length/2)+1; i < polindromeNumber.Length; i++)
                    {
                        secondHalf += polindromeNumber[i];
                    }

                    secondHalf = ReverseString(secondHalf);
                    if (firstHalf == secondHalf)
                    {
                        isPolindome = true;
                        return isPolindome;
                    }
                    else
                    {
                        isPolindome = false;
                        return isPolindome;
                    }
                }
            }
            return false;
        }
        static bool SumOfDigits(int number)
        {
            int sumOfDigits = 0;
            bool isDividable = false;
            if (number >= 0)
            {
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10;
                }

                if (sumOfDigits % 7 == 0)
                {
                    isDividable = true;
                    return isDividable; 
                }
                else
                {
                    isDividable = false;
                    return isDividable;
                }
            }
            return false;
        }
        static  bool ContainsEvenDigits(int number)
        {
            int digit = 0;
            bool isEven = false;
            if (number >= 0)
            {
                
                while (number > 0)
                {
                    digit = number % 10;
                    if (digit % 2 == 0)
                    {
                        isEven = true;
                        break;
                    }
                    else
                    {
                        number /= 10;
                    }
                }
             
            }
            if (isEven == true)
            {
                return isEven;
            }
            else
            {
                return false;
            }
        }
        static void MagicNumber(int number)
        {
            string polindromeNumber = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                if (IsPolindome(i) == true && SumOfDigits(i) == true && ContainsEvenDigits(i) == true)
                {
                    Console.WriteLine($"{i} ");
                }

            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MagicNumber(number);
        }
    }
}
