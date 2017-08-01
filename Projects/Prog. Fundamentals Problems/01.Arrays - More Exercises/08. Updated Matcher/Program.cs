using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Updated_Matcher
{
    class Program
    {
        static List<string> GetProductsNamesValues(string [] productsNames)
        {
            List<string> listOfProductNames = new List<string>();
            for (int i = 0; i < productsNames.Length; i++)
            {
                listOfProductNames.Add(productsNames[i]);
            }
            return listOfProductNames;
        }

        static List<long> GetProductsQuantitiesValues(long[] productsQuantities)
        {
            List<long> listOfProductQuantities = new List<long>();
            for (int i = 0; i < productsQuantities.Length; i++)
            {
                listOfProductQuantities.Add(productsQuantities[i]);
            }
            return listOfProductQuantities;
        }

        static List<decimal> GetProductsPricesValues(decimal[] productsPrices)
        {
            List<decimal> listOfProductsPrices = new List<decimal>();
            for (int i = 0; i < productsPrices.Length; i++)
            {
                listOfProductsPrices.Add(productsPrices[i]);
            }
            return listOfProductsPrices;
        }

        static string GetProductNameFromCommand (string command)
        {
            string productName = string.Empty;
            int i = 0;
            while (command[i] != ' ')
            {
                productName += command[i];
                i++;
            }
            return productName;
        }

        static long GetProductQuantityFromCommand(string command)
        {
            long productQuantity = 0L;
            int i = 0;
            while (command[i] != ' ')
            {
                i++;
            }
            command = command.Remove(0, i + 1);//i + 1 because we want to get rid of the space as well.
            productQuantity = Convert.ToInt64(command);
            return productQuantity;
        }
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(' ').ToArray();
            long[] productsQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] productsPrices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            List<string> listOfProductNames = new List<string>();
            List<long> listOfProductQuantities = new List<long>();
            List<decimal> listOfProductPrices = new List<decimal>();

            listOfProductNames = GetProductsNamesValues(productsNames);
            listOfProductQuantities = GetProductsQuantitiesValues(productsQuantities);
            listOfProductPrices = GetProductsPricesValues(productsPrices);

            if (listOfProductQuantities.Count < listOfProductNames.Count)
            {
                while (listOfProductQuantities.Count < listOfProductNames.Count)
                {
                    listOfProductQuantities.Add(0L);
                }
            }

            string command = string.Empty;
            string productNameFromCommand = string.Empty;//GetProductNameFromCommand(command);
            long productQuantityFromCommand = 0L;//GetProductQuantityFromCommand(command);
            int index = 0;
            do
            {
                command = Console.ReadLine();
                if (command != "done")
                {
                    productNameFromCommand = GetProductNameFromCommand(command);
                    productQuantityFromCommand = GetProductQuantityFromCommand(command);

                    for (int i = 0; i < listOfProductNames.Count; i++)
                    {
                        if (productNameFromCommand == listOfProductNames[i])
                        {
                            index = i;
                            //break;
                        }

                    }
                    if (productQuantityFromCommand <= listOfProductQuantities[index])
                    {
                        Console.WriteLine($"{productNameFromCommand} x {productQuantityFromCommand} costs {(decimal)(productQuantityFromCommand * listOfProductPrices[index]):f2}");//The result should be decimal!!!
                        listOfProductQuantities[index] -= productQuantityFromCommand;
                        //break;
                    }
                    else if (productQuantityFromCommand > listOfProductQuantities[index])
                    {
                        Console.WriteLine($"We do not have enough {listOfProductNames[index]}");
                    } 
                }

            } while (command != "done");
            

        }
    }
}
