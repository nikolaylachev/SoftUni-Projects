using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static double GetReversedNumber(double number)
        {
            string numberToString = number.ToString();
            double reversedNumber = 0.0;
            string reversedNumberToString = "";
            for (int i = numberToString.Length-1; i >= 0 ; i--)
            {
                reversedNumberToString += numberToString[i];
            }
            reversedNumber = Convert.ToDouble(reversedNumberToString);
            return reversedNumber;
        }
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //numbers.Reverse();
            double sum = 0.0;
            //long number = 123L;
            //Console.WriteLine(GetReversedNumber(number));
            foreach (var num in numbers)
            {
                sum += GetReversedNumber(num);
            }
            Console.WriteLine(sum);
        }
    }
}
