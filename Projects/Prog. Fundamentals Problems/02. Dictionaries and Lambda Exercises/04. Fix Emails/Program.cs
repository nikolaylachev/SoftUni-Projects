using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string email = string.Empty;
            Dictionary<string, string> personInfo = new Dictionary<string, string>();
            Dictionary<string, string> newPersonInfo = new Dictionary<string, string>();

            do
            {
                name = Console.ReadLine();
                if (name != "stop")
                {
                    email = Console.ReadLine().ToLower();
                    personInfo[name] = email; 
                }
                else if(name == "stop")
                {
                    foreach(var item in personInfo)
                    {
                        if (item.Value.Contains(".us") || item.Value.Contains(".uk"))
                        {
                            //personInfo.Remove(item.Key);
                        }
                        else
                        {
                            newPersonInfo[item.Key] = item.Value;
                            //newPersonInfo.Add(item.Key,item.Value);   
                        }
                    } 
                }

            } while (name != "stop");
            foreach (var item in newPersonInfo)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
