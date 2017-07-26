using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_some_stuff_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"double max = {double.MaxValue}");
            Console.WriteLine($"ulong max = {ulong.MaxValue > 100000000000}");
            Console.WriteLine($"uint max = {uint.MaxValue > 100000000000}");
            Console.WriteLine($"int max = {int.MaxValue > 100000000000}");
           
        }
    }
}
