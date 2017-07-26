using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Brackets_New_Way
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string randomMessage = string.Empty;
            string brackets = string.Empty;
            for (byte i = 1; i <= n; i++)
            {
                randomMessage = Console.ReadLine();
                if (randomMessage.Contains("("))
                {
                    brackets += randomMessage;
                }
                if (randomMessage.Contains(")"))
                {
                    brackets += randomMessage;
                }
                if (randomMessage.Contains("((") || randomMessage.Contains("))"))
                {
                    Console.WriteLine("UNBALANCED");
                    break;
                }
            }
            Console.WriteLine(brackets);
            int balancedCounter = 0;
           // int unbalancedCounter = 0;
            for (int i = 0; i < brackets.Length; i++)
            {
                if ((brackets[i] == '(' && (i % 2 == 0)) || (brackets[i]==')' && (i % 2 !=0)))
                {
                    balancedCounter++;
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                    break;
                }
                
            }
            if (balancedCounter == brackets.Length && brackets.Length % 2 == 0)
            {
                Console.WriteLine("BALANCED"); 
            }
            else if (balancedCounter == brackets.Length && brackets.Length % 2 != 0)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
