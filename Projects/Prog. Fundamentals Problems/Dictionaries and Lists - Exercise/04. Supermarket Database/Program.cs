using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        class Product
        {
            public string NameOfProduct { get; set; }
            public decimal PriceOfProduct { get; set; }
            public long QuantityOfProduct { get; set; }
        }
        static void Main(string[] args)
        {
            List<string> command = new List<string>();
            Dictionary<string,List<Product>> products = new Dictionary<string, List<Product>>();
            List<Product> p1 = new List<Product>();
            do
            {
                command = Console.ReadLine().Split(' ').ToList();
                if (command[0] != "stocked")
                {
                    if (products.ContainsKey(command[0]))
                    {
                        p1.Add(new Product() { PriceOfProduct = decimal.Parse(command[1]), QuantityOfProduct = long.Parse(command[2]) });
                        products[command[0]] = p1;
                    }
                    else if (!products.ContainsKey(command[0]))
                    {
                        p1.Add(new Product() { PriceOfProduct = decimal.Parse(command[1]), QuantityOfProduct = long.Parse(command[2]) });
                        products.Add(command[0], p1);
                    }
                    p1 = new List<Product>(); 
                }
            } while (command[0]!= "stocked");

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}: ");
                
            }

            List<Product> prList = new List<Product>() { new Product() {NameOfProduct="Beer", PriceOfProduct= 1.20M, QuantityOfProduct = 100L }, new Product() {NameOfProduct = "Cola", PriceOfProduct = 1.50M, QuantityOfProduct = 200L } };
            //for (int i = 0; i < products.Count; i++)
            //{
            //    Console.WriteLine($"{products[i].NameOfProduct}: ${products[i].PriceOfProduct} * ${products[i].QuantityOfProduct} = ${Convert.ToDecimal(products[i].PriceOfProduct * products[i].QuantityOfProduct)}");
            //}
            //for (int i = 0; i < prList.Count; i++)
            //{
            //    Console.WriteLine($"{prList[i].NameOfProduct}, {prList[i].PriceOfProduct}, {prList[i].QuantityOfProduct}");
            //}
            


            //List<string> input;
            //List<Product> products = new List<Product>();
            //Product p = new Product();
            //do
            //{
            //    input = Console.ReadLine().Split(' ').ToList();

            //    if (input[0] != "stocked")
            //    {
            //        //for (int i = 0; i < products.Count; i++)
            //        //{
            //        //    if (products[i].nameOfproduct == input[0])
            //        //    {
            //        //        products.RemoveAt(i);
            //        //        p = new Product();
            //        //        p.nameOfproduct = input[0];
            //        //        p.priceOfProduct = double.Parse(input[1]);
            //        //        p.quantityOfProduct = long.Parse(input[2]);
            //        //        products.Insert(i,p);
            //        //    }
            //        //}
                    
            //        p = new Product();
            //        p.nameOfproduct = input[0];
            //        p.priceOfProduct = double.Parse(input[1]);
            //        p.quantityOfProduct = long.Parse(input[2]);
            //        products.Add(p);

            //    }
            //    else if (input[0] == "stocked")
            //    {
            //        foreach (var item in products)
            //        {
            //            Console.WriteLine($"{item.nameOfproduct}: ${item.priceOfProduct:f2} * {item.quantityOfProduct} = ${(item.priceOfProduct * item.quantityOfProduct):f2}");
            //        }
            //    }
                
            //} while (input[0] != "stocked");
           
            //double sum = 0.0D;
            //foreach (var item in products)
            //{
            //    sum += item.priceOfProduct * item.quantityOfProduct;
            //}
            //Console.WriteLine("------------------------------");
            //Console.WriteLine($"Grand Total: ${(sum):f2}");
            
        }
    }
}
