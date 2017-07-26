using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_RegEx___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumOfCharactersBeforeAtSign = 0;
            int sumOfCharactersAfterAtSign = 0;
            int positionOfAtSign = 0;

            positionOfAtSign = input.IndexOf('@');

            for (int i = 0; i < input.Length; i++)
            {
                if (i>=0 && i < positionOfAtSign)
                {
                    sumOfCharactersBeforeAtSign += input[i];
                }
                else if (i > positionOfAtSign && i < input.Length)
                {
                    sumOfCharactersAfterAtSign += input[i];
                }

            }

            //Console.WriteLine(sumOfCharactersBeforeAtSign);
            //Console.WriteLine(sumOfCharactersAfterAtSign);

            if (sumOfCharactersBeforeAtSign - sumOfCharactersAfterAtSign >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else if (sumOfCharactersBeforeAtSign - sumOfCharactersAfterAtSign < 0)
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
