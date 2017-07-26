using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_21._01._17_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 3 21.01.17  {0} + {1} = {3} – even
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result;
            switch (operation)
            {
                case "+":
                    {
                        result = firstNumber + secondNumber;
                        if (result % 2 == 0)//even
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operation, secondNumber, result);
                        }
                        else//odd
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - odd", firstNumber, operation, secondNumber, result);
                        }
                    }
                    break;
                case "-":
                    {
                        result = firstNumber - secondNumber;
                        if (result % 2 == 0)//even
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operation, secondNumber, result);
                        }
                        else//odd
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - odd", firstNumber, operation, secondNumber, result);
                        }
                    }
                    break;
                case "*":
                    {
                        result = firstNumber * secondNumber;
                        if (result % 2 == 0)//even
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operation, secondNumber, result);
                        }
                        else//odd
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - odd", firstNumber, operation, secondNumber, result);
                        }
                    }
                    break;
                case "/":
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                        }
                        else if (secondNumber != 0)
                        {
                            result = (firstNumber / secondNumber);
                            // Math.Round(result,2);
                            Console.WriteLine("{0} {1} {2} = {3:f2}", firstNumber, operation, secondNumber, Math.Round(result, 2));
                            //Console.WriteLine(Math.Round(result,4));
                        }
                    }
                    break;
                case "%":
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                        }
                        else if (secondNumber != 0)
                        {
                            result = firstNumber % secondNumber;
                            Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operation, secondNumber, Math.Round(result,2));
                        }
                    }
                    break;
                default:
                    break;
            }
           
           
                
                   
        }
    }
}
