using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static long GetQuantityFromCommand(string command)
        {
            string quantityToLong = string.Empty;
            long quantity = 0L;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] >= '0' && command[i] <= '9')
                {
                    quantityToLong += command[i];
                }
            }
            quantity = Convert.ToInt64(quantityToLong);
            return quantity;
        }

        static string GetProductNameFromCommand(string command)
        {
            string productName = string.Empty;
            for (int i = 0; i < command.Length; i++)
            {
                if ((command[i] >= 'a' && command[i] <='z') || (command[i] >='A' && command[i] <='Z'))
                {
                    productName += command[i];
                }
            }
            return productName;
        }

        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(' ').ToArray();
            long[] productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            List<long> listProductsQuantities = new List<long>();
            for (int i = 0; i < productsQuantities.Length; i++)
            {
                listProductsQuantities.Add(productsQuantities[i]);
            }
            listProductsQuantities.Add(0L);
            decimal [] productsPrices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray(); 
            string command;
            //command = Console.ReadLine();
            do
            {
                command = Console.ReadLine();
                // Console.WriteLine($"{productsNames[Array.IndexOf(productsNames, GetProductNameFromCommand(command))]} x {productsQuantities[Array.IndexOf(productsNames, GetProductNameFromCommand(command))]} = {productsPrices[Array.IndexOf(productsNames, GetProductNameFromCommand(command))] * productsQuantities[Array.IndexOf(productsNames, GetProductNameFromCommand(command))]}");
                //Console.WriteLine(productsNames[Array.IndexOf(productsNames, GetProductNameFromCommand(command))]);
                if (command != "done")
                {
                    if (Array.IndexOf(productsNames, GetProductNameFromCommand(command)) == productsNames.Length - 1)
                    {
                        //Console.WriteLine(listProductsQuantities.IndexOf(listProductsQuantities.Last()));
                        //Console.WriteLine($"{productsNames[Array.IndexOf(productsNames, GetProductNameFromCommand(command))]} x {(listProductsQuantities.Last())} = {productsPrices[Array.IndexOf(productsNames, GetProductNameFromCommand(command))] * (listProductsQuantities.Last())}");
                        Console.WriteLine($"We do not have enough {GetProductNameFromCommand(command)}");

                    }
                    else if (Array.IndexOf(productsNames, GetProductNameFromCommand(command)) < productsNames.Length - 1)
                    {
                        if (listProductsQuantities[Array.IndexOf(productsNames, (GetProductNameFromCommand(command)))] > 0)
                        {
                            Console.WriteLine($"{productsNames[Array.IndexOf(productsNames, GetProductNameFromCommand(command))]} x {GetQuantityFromCommand(command)} costs {productsPrices[Array.IndexOf(productsNames, GetProductNameFromCommand(command))] * GetQuantityFromCommand(command)}"); 
                        }
                        listProductsQuantities[Array.IndexOf(productsNames,(GetProductNameFromCommand(command)))] -= GetQuantityFromCommand(command);
                        if (listProductsQuantities[Array.IndexOf(productsNames, (GetProductNameFromCommand(command)))] < 0)
                        {
                            Console.WriteLine($"We do not have enough {GetProductNameFromCommand(command)}");
                        }
                    } 
                }
           } while (command != "done");
            
        }
    }
}
