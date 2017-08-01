using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Biliard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string,int> Order { get; set; }
            public decimal Bill { get; set; }
        }
        
        // 60 % CORRECT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            List<string> command = new List<string>();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split('-').ToList();
                if (products.ContainsKey(command[0]))
                {
                    products[command[0]] = decimal.Parse(command[1]);
                }
                else if (!products.ContainsKey(command[0]))
                {
                    products.Add(command[0], decimal.Parse(command[1]));
                }
            }

            List<Customer> customers = new List<Customer>();
            List<string> orders = new List<string>();

            Dictionary<string, int> ordersFromCustomer = new Dictionary<string, int>();

            do
            {
                orders = Console.ReadLine().Split(new char[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (products.ContainsKey(orders[1]))
                {
                    ordersFromCustomer.Add(orders[1], int.Parse(orders[2]));

                    customers.Add(new Customer() { Name = orders[0],
                        Order = ordersFromCustomer , Bill = decimal.Parse(orders[2]) * products[orders[1]]});
                }
                ordersFromCustomer = new Dictionary<string, int>();

            } while (orders[0]!="end");

            var newCustomers = customers.OrderBy(x => x.Name);
            decimal totalBill = 0.00M;

            foreach (var customer in newCustomers)
            {
                Console.WriteLine($"{customer.Name}");
                foreach (KeyValuePair<string,int> item in customer.Order)
                {
                        Console.WriteLine($"-- {item.Key} - {item.Value}"); 
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
