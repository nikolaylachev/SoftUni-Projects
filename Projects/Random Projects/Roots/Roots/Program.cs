using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roots
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double root = 0.00D;
            for (double i = 0.01; i <= number; i+=0.01)
            {
                if (Math.Pow(i,2)<=number)
                {
                    root = i;
                    
                }
            }
            Console.WriteLine("Square root of {0} is {1}", number, Math.Round(root,2));
        }
    }
}
