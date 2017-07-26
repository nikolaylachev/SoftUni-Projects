using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Fire_Torch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfLRDots = (n / 2) - 1;
            int numberOfMiddleDots = 0;
          
            //Top top
            for (int i = 1; i <= (n/2) ; i++)
            {
                Console.Write(new string('.',numberOfLRDots));
                Console.Write(new string('#',1));
                Console.Write(new string('.',numberOfMiddleDots));
                Console.Write(new string('#',1));
                Console.WriteLine(new string('.',numberOfLRDots));
                numberOfLRDots--;
                numberOfMiddleDots += 2;
            }
            //Top bottom
            numberOfMiddleDots=n-2;
            numberOfLRDots = 0;
            for (int i = 1; i <= n/4; i++)
            {
                Console.Write(new string('.',numberOfLRDots));
                Console.Write(new string('#',1));
                Console.Write(new string('.',numberOfMiddleDots));
                Console.Write(new string('#',1));
                Console.WriteLine(new string('.',numberOfLRDots));
                numberOfLRDots++;
                numberOfMiddleDots -= 2;
            }
            

            //Middle
            Console.WriteLine(new string('-',n));
            //Bottom

            int numberOfLCherta = n / 2;
            int numberOfRCherta = n / 2;
            numberOfLRDots = 0;
            for (int i = 1; i <= n/2; i++)
            {
                Console.Write(new string('.',numberOfLRDots));
                Console.Write(new string('\\',numberOfLCherta));
                Console.Write(new string('/',numberOfRCherta));
                Console.WriteLine(new string('.',numberOfLRDots));
                numberOfLRDots++;
                numberOfLCherta--;
                numberOfRCherta--;
            }

        }
    }
}
