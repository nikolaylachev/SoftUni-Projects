using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] command = new string[1];
            string resource = string.Empty;
            long quantity;
            Dictionary<string, long> resources = new Dictionary<string, long>();
            
            do
            {
                resource = Console.ReadLine();
                if (resource != "stop")
                {
                    quantity = long.Parse(Console.ReadLine());
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;
                    }
                    else if(!resources.ContainsKey(resource))
                    {
                        resources[resource] = quantity;
                    }
                }
                else
                {
                    break;  
                }

            } while (resource != "stop");

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
