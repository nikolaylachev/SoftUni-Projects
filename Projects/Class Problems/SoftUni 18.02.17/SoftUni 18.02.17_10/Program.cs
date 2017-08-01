using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_10
{
    class Program
    {
        static ulong Factorial(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return n * Factorial(n - 1);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            //Problem 13 Fucking Shit!!! Done!
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int variable = 0;
            for (int row = 1; row <= n; row++)
            {
              
                result += variable;
                if (result==n)
                {
                    break;
                }
                for (int col = 1; col <= row; col++)
                {
                    result++;
                   
                    Console.Write("{0} ", result);
                    if (result == n)
                    {
                        break;
                    }
                }
                
                Console.WriteLine();
            }
           
        }
    }
}
