using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniada_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Top
            int numberOfLeftRightDotsForTop = n - 1;
            Console.Write(new string('.',numberOfLeftRightDotsForTop));
            Console.Write("_/_");
            Console.WriteLine(new string('.',numberOfLeftRightDotsForTop));

            //Middle Top
            int numberOfDotsForMiddleTop = n - 2;
            Console.Write(new string('/',1));
            Console.Write(new string('.', numberOfDotsForMiddleTop));
            Console.Write("^,^");
            Console.Write(new string('.',numberOfDotsForMiddleTop));
            Console.WriteLine(new string('\\',1));

            //Middle
            for (int i = 1; i <=n-3 ; i++)
            {
                Console.Write(new string('|',1));
                Console.Write(new string('.',(2*n)-1));
                Console.WriteLine(new string('|',1));
            }

            //Bottom
            int numberOfDotsForBottom = n - 2;
            Console.Write(new string('\\',1));
            Console.Write(new string('.', numberOfDotsForBottom));
            Console.Write("\\_/");
            Console.Write(new string('.', numberOfDotsForBottom));
            Console.WriteLine(new string('/',1));
        }
    }
}
