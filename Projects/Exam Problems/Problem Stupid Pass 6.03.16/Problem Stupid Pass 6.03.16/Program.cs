using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Stupid_Pass_6._03._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int firstSymbol=97;//CHAR!!! first symbol 'a'=97
            int secondSymbol = 97;//CHAR!!! same
            int thirdNumber = firstNumber+1;
            int n = int.Parse(Console.ReadLine());//Given in the condition
            int l = int.Parse(Console.ReadLine());
            for (firstNumber=1; firstNumber <= n; firstNumber++)
            {
                for (secondNumber = 1; secondNumber <= n; secondNumber++)
                {
                    for (firstSymbol = 97; firstSymbol <= (l+97)-1; firstSymbol++)
                    {
                        for (secondSymbol = 97; secondSymbol <= (l+97)-1; secondSymbol++)
                        {
                            for (thirdNumber = 1; thirdNumber <= n; thirdNumber++)
                            {
                                if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", firstNumber, secondNumber, (char)firstSymbol, (char)secondSymbol, thirdNumber);
                                }
                            }
                        }
                    }
                }
            }

            
            
        }
    }
}
