using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexademicalNumber = Convert.ToString(decimalNumber, 16);
            string binaryNumber = Convert.ToString(decimalNumber, 2);
            Console.WriteLine(hexademicalNumber.ToUpper());
            Console.WriteLine(binaryNumber.ToUpper());
        }
    }
}
