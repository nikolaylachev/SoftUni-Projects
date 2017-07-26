using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long total = 0;
            if (firstNumber >=0 && firstNumber <=sbyte.MaxValue)
            {
                total += 4 * firstNumber;
            }
            else if (firstNumber > sbyte.MaxValue && firstNumber <= int.MaxValue)
            {
                total += 10 * firstNumber;
            }

            if (secondNumber >= 0 && secondNumber <= sbyte.MaxValue)
            {
                total += 4 * secondNumber;
            }
            else if (secondNumber > sbyte.MaxValue && secondNumber <= int.MaxValue)
            {
                total += 10 * secondNumber;
            }
            Console.WriteLine(total);
        }
    }
}
