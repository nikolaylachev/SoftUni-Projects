using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales
{
    class Program
    {
        class Sales
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }   
        }

        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sales [] sales = new Sales[n];
            for (int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split(' ');
                var sale = new Sales()
                {
                    Town = items[0],
                    Product = items[1],
                    Price = decimal.Parse(items[2]),
                    Quantity = decimal.Parse(items[3])
                };
                sales[i] = sale;
            }
            SortedDictionary<string, decimal> SalesByTown = new SortedDictionary<string, decimal>();
            decimal sum = 0M;
            //decimal oldSum = 0M;
            for (int i = 0; i < sales.Length; i++)
            {
                if (SalesByTown.ContainsKey(sales[i].Town))
                {
                    sum += sales[i].Price * sales[i].Quantity;//Takes the sum of the current dictionary element
                    SalesByTown[sales[i].Town] += sum;//Adds it in the dictionary element with the same key.
                    sum = 0M;
                }
                else if (!SalesByTown.ContainsKey(sales[i].Town))
                {
                    //sum = 0M;
                    sum += sales[i].Price * sales[i].Quantity;
                    SalesByTown[sales[i].Town] = sum;//
                    sum = 0M;
                }
            }
            foreach (var item in SalesByTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }   
        }
    }
}
