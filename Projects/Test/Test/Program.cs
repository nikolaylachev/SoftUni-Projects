using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("For + enter 1, for - enter 2, for * enter 3, for / enter 4: ");
            int choice;     // int choice=8;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1: Console.WriteLine("Result: " + (a+b));
                    break;

                case 2: Console.WriteLine("Result: " + (a-b));
                    break;

                case 3: Console.WriteLine("Result: " + (a*b));
                    break;

                case 4: Console.WriteLine("Result: " + (a/b));
                    break;

                default: Console.WriteLine("Invalid command!");
                    break;
            }
            Console.Read();


        }
    }
}
