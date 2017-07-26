using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_variable_values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");

            Console.WriteLine("After:");
            Console.WriteLine($"a = {(firstNumber+secondNumber)-firstNumber}");
            Console.WriteLine($"b = {(firstNumber+secondNumber)-secondNumber}");
        }
    }
}
