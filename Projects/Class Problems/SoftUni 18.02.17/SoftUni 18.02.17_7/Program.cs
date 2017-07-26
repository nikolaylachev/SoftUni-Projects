using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_7
{
    class Program
    {
        //Използване на try-catch.
        static void Main(string[] args)
        {
            decimal number=1;
            do
            {

                try
                {
                    Console.Write("Еnter even number: ");
                    number = decimal.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid number"); ;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Invalid number");
                }
            }
            while ( number%2!=0);
        }
    }
}
