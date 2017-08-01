using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_To_Binary
{
    class Program
    {
        //Function for reversing a string.
        static string ReverseString(string originalString)
        {
            string ReversedString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                ReversedString += originalString[i];
            }
            return ReversedString;
        }
        //Function that converts decimal number to binary number.
        static void DecimalToBinary(int decimalNumber)
        {
            string reversedBinaryNumber = string.Empty;
            string binaryNumber = string.Empty;
            int copyOfDecimalNumber = decimalNumber;
            do
            {
                if (decimalNumber % 2 == 0)
                {
                    reversedBinaryNumber += "0";
                }
                else if (decimalNumber % 2 == 1)
                {
                    reversedBinaryNumber += "1";
                }
                else if (decimalNumber == 2)
                {
                    reversedBinaryNumber += "0";
                }

                else if (decimalNumber == 1)
                {
                    reversedBinaryNumber += "1";
                }

                decimalNumber /= 2;
                
                

            }
            while (decimalNumber > 0);

            if (reversedBinaryNumber.Length % 4 == 1)
            {
                reversedBinaryNumber += "000";
            }
            if (reversedBinaryNumber.Length % 4 == 2)
            {
                reversedBinaryNumber += "00";
            }
            if (reversedBinaryNumber.Length % 4 == 3)
            {
                reversedBinaryNumber += "0";
            }
            binaryNumber = ReverseString(reversedBinaryNumber);
            Console.WriteLine("The binary of {0} is: {1}",copyOfDecimalNumber,binaryNumber);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int a = int.Parse(Console.ReadLine());
            DecimalToBinary(a);
           
            }//01001000 01100101 01101100 01101100 01101111 00100000 01101101 01100001 01100100 01100001 01100110 01100001 01100011 01101011 01100001 00100001
        }
    }
}
