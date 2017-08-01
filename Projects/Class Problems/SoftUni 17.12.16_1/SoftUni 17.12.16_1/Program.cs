using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_17._12._16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*',n));
            for (int i = 1; i <= n-2 ; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ',n-2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*',n));
        }
    }
}
