using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace String_and_Text___Exercises
{
    class Program
    {
        static string ReverseString(string str)
        {
            string reversed = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }

        static void Main(string[] args)
        {
            BigInteger[] numberInDecimal = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger number = numberInDecimal[1];
            BigInteger numericBase = numberInDecimal[0];

            string numberInNewBase = "";

            do
            {
                if (number > 0)
                {
                    numberInNewBase += (number % numericBase).ToString();
                    number /= numericBase;
                }
                else if(number == 0)
                {
                    break;
                }

            } while (number > 0);
            
            Console.WriteLine(ReverseString(numberInNewBase));
            /*
             * 1 0
             * 1 3    
             * 
             * 
             * 
             * 
             * 
             * 
             * */
        }
    }
}
