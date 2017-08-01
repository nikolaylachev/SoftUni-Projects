using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Axe_28._08._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            int numberOfLeftDashes = 3 * n;
            int numberOfRightDashes = (5 * n) - (3 * n) - 2;
            int numberOfMiddleDashes = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',numberOfLeftDashes),new string('-',numberOfMiddleDashes),new string('-',numberOfRightDashes));
                numberOfMiddleDashes++;
                numberOfRightDashes--;
            }

            //Middle
            int numberOfLeftStars = 3 * n;
            numberOfMiddleDashes = n - 1;
            numberOfRightDashes = (5 * n) - (3 * n) - (n - 1) - 2;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('*',numberOfLeftStars), new string('-',numberOfMiddleDashes), new string('-',numberOfRightDashes));
            }

            //Bottom
            numberOfLeftDashes = 3 * n;
            numberOfMiddleDashes = n - 1;
            numberOfRightDashes = (5 * n) - (3*n) - (n - 1) - 2;
            for (int i = 1; i <= (n/2); i++)
            {

                if (i<n/2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', numberOfLeftDashes), new string('-', numberOfMiddleDashes), new string('-', numberOfRightDashes)); 
                }
                else if (i==n/2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-',numberOfLeftDashes), new string('*',numberOfMiddleDashes), new string('-',numberOfRightDashes));
                }
                numberOfMiddleDashes += 2;
                numberOfRightDashes--;
                numberOfLeftDashes--;
            }

            
        }
    }
}
