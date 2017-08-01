using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_21._01._17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            switch (productName)
            {
                case "apple":                    // case "apple":
                    Console.WriteLine("fruit");  // case "banana":
                    break;                       // case "kiwi":
                case"banana":                    // Console.WriteLine("fruit");
                    Console.WriteLine("fruit");  //break;
                    break;
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                default:
                    break;
            }

        }
    }
}
