using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 11;
            //Console.WriteLine(Convert.ToString(a, 16));
            string input = Console.ReadLine();
            var result = input.Select(t => $"\\u{Convert.ToUInt16(t):X4}".ToLower()).ToList();
            Console.WriteLine(string.Join("",result));
        }
    }
}
