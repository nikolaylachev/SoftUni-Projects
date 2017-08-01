using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Personal_Exception
{
    class Program
    {
        class NegativeNumberException : Exception
        {
            public NegativeNumberException() : base()
            {
                Console.WriteLine("My first exception is awesome!!!");
            }
        }

        static void Main(string[] args)
        {
            int number = 0;
            while (number >= 0)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number >= 0)
                    {
                        Console.WriteLine(number);
                    }
                    else if (number < 0)
                    {
                        throw new NegativeNumberException();
                    }
                }
                catch (NegativeNumberException)
                {

                }
            }
        }
    }
}
