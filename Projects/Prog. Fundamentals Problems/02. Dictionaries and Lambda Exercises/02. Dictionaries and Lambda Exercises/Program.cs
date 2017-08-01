using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dictionaries_and_Lambda_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command;
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            bool isNotInPhoneBook = true;

            do
            {
                command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "A":
                        {
                            phonebook[command[1]] = command[2];
                        }
                        break;
                    case "S":
                        {
                            foreach (var item in phonebook)
                            {
                                if (item.Key == command[1])
                                {
                                    isNotInPhoneBook = false;
                                    Console.WriteLine($"{item.Key} -> {item.Value}");
                                    break;
                                }
                                else
                                {
                                    isNotInPhoneBook = true;
                                    //Console.WriteLine($"Contact {command[1]} does not exist.");
                                }
                            }
                            if (isNotInPhoneBook == true)
                            {
                                Console.WriteLine($"Contact {command[1]} does not exist.");
                            }
                        }
                        break;
                    case "ListAll":
                        {
                            foreach (var item in phonebook)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                        break;
                    default:
                        break;
                } 
            } while (command[0] != "END");
        }
    }
}
