using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_to_decimal
{
    class Program
    {
        //Function that reverses a string.
        static string ReverseString(string str1)
        {
            string reverse = String.Empty;
            for (int i = str1.Length-1; i >=0; i--)
            {
                reverse += str1[i];
            }
            return reverse;
        }
        //Function for converting binary numbers to decimal.
        static void BinaryToDecimal(string str1)
        {
            string reversedString = ReverseString(str1);
            double decimalNumber = 0.0D;
            for (int i = 0; i < reversedString.Length; i++)
            {
                if (reversedString[i] == '1')
                {
                    decimalNumber += (1 * Math.Pow(2, i));
                }
                else if (reversedString[i] == '0')
                {
                    decimalNumber += (0 * Math.Pow(2, i));
                }
                else if (reversedString[i]==' ')
                {
                    decimalNumber += 0;
                }
                else
                {
                    Console.WriteLine("You must enter characters between 0 and 1 only!");
                    break;
                }
            }
            Console.WriteLine("The decimal of {0} is {1}",str1,decimalNumber);
        }
        //Function for finding the hexadeciaml.
        static void BinaryToHexademical(string originalBinaryNumber)
        {
            string hexademical = "";
            if (originalBinaryNumber.Length%4==0)
            {
                for (int i = 0; i < originalBinaryNumber.Length; i += 4)
                {
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "0";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "1";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "2";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "3";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "4";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "5";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "6";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "7";
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "8";
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "9";
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "A";//10
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "B";//11
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "C";//12
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "D";//13
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "E";//14
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "F";//15
                    }
                }
                Console.WriteLine("The hexademical of {0} is {1}",originalBinaryNumber,hexademical) ;
            }
            else if (originalBinaryNumber.Length%4!=0)
            {
                string reversedBinaryNumber = ReverseString(originalBinaryNumber);
                //Adding the needed zeros for the binary numbers which are not evanly dividable by 4
                if (originalBinaryNumber.Length % 4 == 1)
                {
                    reversedBinaryNumber += "000";
                    originalBinaryNumber = String.Empty;
                    for (int i = reversedBinaryNumber.Length - 1; i >= 0; i--)
                    {
                        originalBinaryNumber += reversedBinaryNumber[i];
                    }
                    //Console.WriteLine("Original binary number={0}",originalBinaryNumber);
                }
                else if (originalBinaryNumber.Length % 4 == 2)
                {
                    reversedBinaryNumber += "00";
                    originalBinaryNumber = String.Empty;
                    for (int i = reversedBinaryNumber.Length - 1; i >= 0; i--)
                    {
                        originalBinaryNumber += reversedBinaryNumber[i];
                    }
                    //Console.WriteLine("Original binary number={0}",originalBinaryNumber);
                }
                else if (originalBinaryNumber.Length % 4 == 3)
                {
                    reversedBinaryNumber += "0";
                    originalBinaryNumber = String.Empty;
                    for (int i = reversedBinaryNumber.Length - 1; i >= 0; i--)
                    {
                        originalBinaryNumber += reversedBinaryNumber[i];
                    }
                    // Console.WriteLine("Original binary number={0}",originalBinaryNumber);
                }
                //Finding the hexademical
                for (int i = 0; i < originalBinaryNumber.Length; i += 4)
                {
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "0";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "1";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "2";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "3";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "4";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "5";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "6";
                    }
                    if (originalBinaryNumber[i] == '0' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "7";
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "8";
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "9";
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "A";//10
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '0' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "B";//11
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "C";//12
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '0' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "D";//13
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '0')
                    {
                        hexademical += "E";//14
                    }
                    if (originalBinaryNumber[i] == '1' && originalBinaryNumber[i + 1] == '1' && originalBinaryNumber[i + 2] == '1' && originalBinaryNumber[i + 3] == '1')
                    {
                        hexademical += "F";//15
                    }
                }
                Console.WriteLine("The hexademical of {0} is {1}", originalBinaryNumber, hexademical);
            }

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
            //Adding necessary zeroes.
            if (reversedBinaryNumber.Length % 4 == 1)
            {
                reversedBinaryNumber += "000";
            }
            if (reversedBinaryNumber.Length % 4 ==2)
            {
                reversedBinaryNumber += "00";
            }
            if (reversedBinaryNumber.Length % 4 == 3)
            {
                reversedBinaryNumber += "0";
            }
           
            binaryNumber = ReverseString(reversedBinaryNumber);
            Console.WriteLine("The binary of {0} is: {1}", copyOfDecimalNumber, binaryNumber);
            
        }
        //Function that converts decimal number to binary number. (Second way)
        static void DecimalToBinarySecondWay(double decimalNumber)
        {
            string binaryNumber = string.Empty;
            if (decimalNumber >= 0)
            {
                for (int i = 30; i >= 0; i--)
                {
                    if (decimalNumber >= Math.Pow(2, i))
                    {
                        binaryNumber += "1";
                        decimalNumber -= (Math.Pow(2, i));
                    }
                    else if (decimalNumber < Math.Pow(2, i))
                    {
                        binaryNumber += '0';
                    }
                }
                Console.WriteLine(binaryNumber);
            }
        }

        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.Write("Enter binary number: ");
                string originalBinaryNumber = Console.ReadLine();
                string reversedBinaryNumber = "";
                string binaryNumberCopy = originalBinaryNumber;//Only used for the output

                 //Reversing the string
                    reversedBinaryNumber = ReverseString(originalBinaryNumber);

                    BinaryToDecimal(originalBinaryNumber);//Printing the decimal number
                    BinaryToHexademical(originalBinaryNumber);
                
                Console.Write("Do you want to convert again: ");
                answer = Console.ReadLine();
            }
            while (answer=="yes" || answer=="Yes" || answer=="YES" || answer=="y" || answer=="Y");
           
        }
    }
}
