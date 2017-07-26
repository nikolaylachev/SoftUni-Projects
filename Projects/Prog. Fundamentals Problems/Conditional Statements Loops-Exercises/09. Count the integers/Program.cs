using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter = 0;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine());//Try this input and if it gives an exception go to the catch block.
                }
                catch (Exception)
                {
                    break;//If the Console.ReadLine() returned an exception leave the loop's body.
                }
                counter++;
            }while (true);
            Console.WriteLine(counter);
        }
    }
}
