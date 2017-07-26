using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int start = 2; start <= n; start++)
            {
                bool isPrime = true;
                for (int delio = 2; delio <= Math.Sqrt(start); delio++)
                {
                    if (start % delio == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{start} -> {isPrime}");
            }

        }
    }
}
