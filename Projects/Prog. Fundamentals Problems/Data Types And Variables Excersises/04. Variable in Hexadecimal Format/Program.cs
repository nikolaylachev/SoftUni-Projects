using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexademicalNumber = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(hexademicalNumber,16);
            Console.WriteLine(decimalNumber);
        }
    }
}
