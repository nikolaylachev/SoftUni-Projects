using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantity*0.70):f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {profession} has to pay {(quantity*1.00):f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.00):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.70):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.20):f2}.");
                    break;
            }
        }
    }
}
