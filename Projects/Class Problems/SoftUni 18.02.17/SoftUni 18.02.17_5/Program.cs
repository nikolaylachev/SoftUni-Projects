using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_5
{
    class Program
    {
        static ulong Recurtion(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }
            if(n > 0)
            {
                return (n * Recurtion(n - 1));    
            }
            return 0;
        }
        static void Main(string[] args)
        {
            ulong n = 
            Recurtion(ulong.Parse(Console.ReadLine()));
            Console.WriteLine(n);
        }
    }
}
