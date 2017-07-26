using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_between_numbers
{
    class Program
    {
        static int Max (int fisrtNumber, int secondNumber)
        {
            return (fisrtNumber > secondNumber) ? fisrtNumber : secondNumber;
        }
        static int Min (int firstNumber, int secondNumber)
        {
            return (firstNumber < secondNumber) ? firstNumber : secondNumber;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = Min(firstNumber,secondNumber); i <= Max(firstNumber,secondNumber); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
