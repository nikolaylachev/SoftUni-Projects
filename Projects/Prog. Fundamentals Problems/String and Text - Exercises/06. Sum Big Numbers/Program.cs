using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static StringBuilder ReverseStringBuilder(StringBuilder result)
        {
            StringBuilder reversed = new StringBuilder("");
            for (int i = result.Length-1; i >= 0; i--)
            {
                reversed.Append(result[i]);
            }

            while(true)
            {
                int i = 0;
                if (reversed[i] == '0')
                {
                    reversed.Remove(i, 1);
                }
                else
                {
                    break;
                }
            }
            return reversed;
        }

        static StringBuilder GetSumOfBigNumbers(StringBuilder firstNumber, StringBuilder secondNumber)
        {
            StringBuilder sumToString = new StringBuilder("");
            int sum = 0;
            int reminider = 0;

            if (firstNumber.Length == secondNumber.Length)
            {
                firstNumber = firstNumber.Insert(0, "0");
                secondNumber = secondNumber.Insert(0, "0");
                for (int i = firstNumber.Length-1; i >= 0; i--)
                {
                    sum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString());
                    if (sum >= 10)
                    {
                        sumToString.Append((sum % 10) + reminider);
                        reminider = 1;
                    }
                    else if (sum < 10)
                    {
                        sumToString.Append((sum % 10) + reminider);
                        reminider = 0;
                    }
                }
            }

            else if (firstNumber.Length != secondNumber.Length)
            {
                if (firstNumber.Length > secondNumber.Length)
                {
                    secondNumber = secondNumber.Insert(0, new string('0', Math.Abs(firstNumber.Length - secondNumber.Length)));
                    firstNumber.Insert(0, "0");
                    secondNumber.Insert(0, "0");

                    for (int i = firstNumber.Length-1; i >= 0; i--)
                    {
                        sum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString());
                        if (sum >= 10)
                        {
                            sumToString.Append((sum + reminider)%10);
                            reminider = 1;
                        }
                        else if (sum < 10)
                        {
                            sumToString.Append((sum  + reminider) % 10);
                            if ((sum+reminider) % 10 == 0 && (sum+reminider) != 0)
                            {
                                reminider = 1;
                            }
                            else
                            reminider = 0;
                        }
                    }
                }
                else if (secondNumber.Length > firstNumber.Length)
                {
                    firstNumber = firstNumber.Insert(0, new string('0', Math.Abs(secondNumber.Length - firstNumber.Length)));
                    firstNumber.Insert(0, "0");
                    secondNumber.Insert(0, "0");

                    for (int i = firstNumber.Length - 1; i >= 0; i--)
                    {
                        sum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString());
                        if (sum >= 10)
                        {
                            sumToString.Append((sum % 10) + reminider);
                            reminider = 1;
                        }
                        else if (sum < 10)
                        {
                            sumToString.Append((sum + reminider) % 10);
                            if ((sum + reminider) % 10 == 0 && (sum + reminider) != 0)
                            {
                                reminider = 1;
                            }
                            else
                                reminider = 0;
                        }
                    }
                }
            }
            return sumToString;
        }

        static void Main(string[] args)
        { 
            StringBuilder firstNumber = new StringBuilder(Console.ReadLine());
            StringBuilder secondNumber = new StringBuilder(Console.ReadLine());
            StringBuilder result = ReverseStringBuilder(GetSumOfBigNumbers(firstNumber,firstNumber));
            //Console.WriteLine(ReverseStringBuilder(GetSumOfBigNumbers(firstNumber,secondNumber)));

            for (int i = 1; i < int.Parse(secondNumber.ToString()); i++)
            {
                result = (ReverseStringBuilder(GetSumOfBigNumbers(firstNumber, result)));
            }
            Console.WriteLine(result);
            
        }
    }
}
