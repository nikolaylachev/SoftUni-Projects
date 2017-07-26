using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            string itemName;
            double itemPrice;
            int itemCount;
            double subtotal = 0.00D;
            for (int i = 1; i <= numberOfItems; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());
                if (itemCount==1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                    subtotal += (itemPrice*itemCount); 
                }
                else if (itemCount>1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                    subtotal += (itemPrice * itemCount);
                }
            }
            if (budget >= subtotal)
            {
                Console.WriteLine($"Subtotal: ${subtotal:f2}");
                Console.WriteLine($"Money left: ${(budget-subtotal):f2}");
            }
            else if (budget < subtotal)
            {
                Console.WriteLine($"Subtotal: ${subtotal:f2}");
                Console.WriteLine($"Not enough. We need ${(subtotal-budget):f2} more.");
            }
        }
    }
}
