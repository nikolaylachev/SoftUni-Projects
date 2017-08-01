using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string str2 = "World";
            object obj = str + " " + str2;
            string str3 = (string)obj;
            Console.WriteLine(str3);
        }
    }
}
