using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Fibonacci_Modified_HackerRank
{
    class Program
    {
        static BigInteger Power(BigInteger number, BigInteger power)
        {
            if (power>1)
            {
                for (int i = 1; i <= power - 1; i++)
                {
                    number *= number;
                }
                return number; 
            }
            else if (power==1)
            {
                return number;
            }
            else if (power==0)
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        { 
            string[] input = Console.ReadLine().Split(' ');
            BigInteger first = Convert.ToInt64(input[0]);
            BigInteger second = Convert.ToInt64(input[1]);
            double n = Convert.ToDouble(input[2]);
            BigInteger fibonacci = 0; 
            for (int i = 1; i <= n-2; i++)
            {
                fibonacci = (first + Power(second, 2));
                first = second;
                second = fibonacci;
            }
            Console.WriteLine("{0}",fibonacci);
        }
    }
}
