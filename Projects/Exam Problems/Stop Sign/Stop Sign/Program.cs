using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.',n+1));
            Console.Write(new string('_',(2*n)+1));
            Console.WriteLine(new string('.',n+1));
            //Middle Top
            int numberOfLeftRightPoint = n;
            int numberOfDashes = (2 * n) - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.',numberOfLeftRightPoint));
                Console.Write("//");
                Console.Write(new string('_',numberOfDashes));
                Console.Write("\\\\");
                Console.WriteLine(new string('.',numberOfLeftRightPoint));
                numberOfLeftRightPoint--;
                numberOfDashes += 2;
            }
            //Middle
            Console.Write("//");
            int numberOfLRDashes = (((n * 4) - 1) - 5) / 2;//Very special formula!
            Console.Write(new string('_',numberOfLRDashes));
            Console.Write("STOP!");
            Console.Write(new string('_',numberOfLRDashes));
            Console.WriteLine("\\\\");
            //Bottom
            numberOfDashes = (4 * n) - 1;
            numberOfLeftRightPoint = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.',numberOfLeftRightPoint));
                Console.Write("\\\\");
                Console.Write(new string('_',numberOfDashes));
                Console.Write("//");
                Console.WriteLine(new string('.',numberOfLeftRightPoint));
                numberOfLeftRightPoint++;
                numberOfDashes -= 2;
            }
        }
    }
}
