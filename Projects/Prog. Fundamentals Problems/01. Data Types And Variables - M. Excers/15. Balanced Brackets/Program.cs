using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string randomString = string.Empty;
            int bracketsCounter = 0;
            int openingBracketsCounter = 0;
            int closingBracketsCounter = 0;
            int unbalancedCounter = 0;

            for (byte i = 1; i <= n; i++)
            {
                randomString = Console.ReadLine();

                if (randomString != "((" && randomString != "))")
                {
                    if (randomString.Contains("("))
                    {
                        openingBracketsCounter++;
                    }

                    if (randomString.Contains(")"))
                    {
                        closingBracketsCounter++;
                    } 
                }

                else if (randomString == "((" || randomString == "))")
                {
                    Console.WriteLine("UNBALANCED");
                    unbalancedCounter++;
                    break;
                }
                randomString = string.Empty;
                
            }

            bracketsCounter = openingBracketsCounter + closingBracketsCounter;
            //Console.WriteLine(bracketsCounter);
            if (bracketsCounter > 0)
            {
                if (openingBracketsCounter == closingBracketsCounter)
                {
                    Console.WriteLine("BALANCED");
                }
                else if (openingBracketsCounter != closingBracketsCounter)
                {
                    Console.WriteLine("UNBALANCED");
                } 
            }
            else if (bracketsCounter == 0 && unbalancedCounter == 0)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
