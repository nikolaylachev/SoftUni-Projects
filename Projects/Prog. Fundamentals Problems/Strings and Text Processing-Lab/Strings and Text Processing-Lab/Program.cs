using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Processing_Lab
{
    class Program
    {
        static string ReverseString(string str)
        {
            string reversedStr = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            return reversedStr;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(ReverseString(str));
        }
    }
}
