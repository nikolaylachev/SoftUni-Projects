using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_4
{
    class Program
    {
        // Алгоритъма на Евклид!
        static int gcd(int a, int b)
        {

            if (b == 0)
            {
                return a;
            }
                
            else
            {
                return gcd(b, a % b);
            }
                
        }

        static void Main(string[] args)
        {
            //Problem 7
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(gcd(firstNumber,secondNumber));

        }
    }
}
