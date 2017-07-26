using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _02.Convert_from_n_to_10_base
{
    class Program
    {
        static string ReverseString(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }

        static BigInteger BigIntegerPower (BigInteger number, BigInteger power)
        {
            BigInteger poweredNumber = 1;
            if (power > 0)
            {
                for (int i = 1; i <= power; i++)
                {
                    poweredNumber *= number;
                } 
            }
            else if (power == 0)
            {
                poweredNumber = 1;
            }
            return poweredNumber;
        }

        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger numericBase =  input[0];
            BigInteger number = input[1];
            BigInteger sum = 0;

            string reversedNumberString = ReverseString(number.ToString());
            //BigInteger reversedNumber = BigInteger.Parse(reversedNumberString);

            for (int i = 0; i < reversedNumberString.Length; i++)
            {
                sum += BigInteger.Parse(reversedNumberString[i].ToString()) * BigIntegerPower(numericBase,i);
            }

            //BigInteger a = 5;
            Console.WriteLine(sum);

        }
    }
}
