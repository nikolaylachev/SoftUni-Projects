using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 5 - Slav's solution.
            int maxNumber = int.Parse(Console.ReadLine());
            int firstNumber = 1;
            while (firstNumber<=maxNumber)
            {
                Console.WriteLine(firstNumber);
                firstNumber = 2 * firstNumber + 1;
            }
        }
    }
}
