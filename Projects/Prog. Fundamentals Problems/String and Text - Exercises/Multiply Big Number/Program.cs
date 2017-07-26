using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    class Program
    {
        static StringBuilder ReverseStringBuilder (StringBuilder strb)
        {
            StringBuilder reversed = new StringBuilder("");
            for (int i = strb.Length-1; i >= 0; i--)
            {
                reversed.Append(strb[i]);
            }
            while (true)
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

        static StringBuilder GetMultiplitionOfTheTwoNumbers(StringBuilder firstNumber, StringBuilder secondNumber )
        {
            int sum = 0;
            int reminder = 0;
            StringBuilder sumTostring = new StringBuilder("");
            firstNumber = firstNumber.Insert(0, '0');
            //StringBuilder reversed = ReverseStringBuilder(firstNumber);

            for (int i = firstNumber.Length-1, j=0; i >= 0; i--)
            {
                sum = int.Parse(firstNumber[i].ToString()) * int.Parse(secondNumber[j].ToString());

                if (sum >= 10)
                {
                    if ((sum % 10) + reminder < 10)
                    {
                        sumTostring.Append((sum % 10) + reminder);
                        reminder = sum / 10;   
                    }
                    else if ((sum % 10) + reminder >=10)
                    {
                        sumTostring.Append(((sum % 10) + reminder) % 10);
                    }
                }

                else if (sum < 10)
                {

                    if (reminder > 0)
                    {
                        if ((sum % 10) + reminder < 10)
                        {
                            sumTostring.Append((sum % 10) + reminder);
                            reminder = sum / 10;
                        }
                        else if ((sum % 10) + reminder >= 10)
                        {
                            sumTostring.Append(((sum % 10) + reminder) % 10);
                        }
                        reminder = ((sum % 10) + reminder) /10;
                        /* sumTostring.Append((sum % 10) + reminder); 

                      reminder = 0; */
                    }

                    else if (reminder == 0)
                    {
                        sumTostring.Append(sum % 10);
                    }
                }
            }
            return sumTostring;
        }

        static void Main(string[] args)
        {
            //3,695,388,955,727,932,769,851,328,408 - From a calculator
            //3 695 388 955 727 932 769 851 328 408 - From another calculator
            //36 953 889 557 279 327 698 411 328 408 - My answer
            //  923 847 238 931 983 192 462 832 102 - 923847238931983192462832102
            // 123456789 * 4 = 493,827,156
            //                 4 938 261 156 
            StringBuilder firstNumber =  new StringBuilder(Console.ReadLine());
            StringBuilder secondNumber = new StringBuilder(Console.ReadLine());
            Console.WriteLine(ReverseStringBuilder( GetMultiplitionOfTheTwoNumbers(firstNumber,secondNumber)));

        }
    }
}
