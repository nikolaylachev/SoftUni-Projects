using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_To_Binary
{
    class Program
    {
        static string ReverseString(string originalString)
        {
            string ReversedString = string.Empty;
            for (int i = originalString.Length-1; i >= 0; i--)
            {
                ReversedString += originalString[i];
            }
            return ReversedString;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string reversedBinaryNumber = string.Empty;
            string binaryNumber = string.Empty;
            do
            {
                if (a % 2 == 0)
                {
                    reversedBinaryNumber += "0";
                }
                else if (a % 2 == 1)
                {
                    reversedBinaryNumber += "1";
                }
                else if (a==2)
                 {
                  reversedBinaryNumber += "0";
                 }

                else if (a==1)
                {
                  reversedBinaryNumber += "1";
                }
               
                a /= 2;
            
            }
            while (a > 0);
            binaryNumber = ReverseString(reversedBinaryNumber);
            Console.WriteLine("{0}",binaryNumber);
        }
    }
}
