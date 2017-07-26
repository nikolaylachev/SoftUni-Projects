using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static string GetStringFromCommand(string command)
        {
            command = command.Remove(0, 7);
            return command;
        }
        static long GetNumberFromCommandForDelete(string command)
        {
            command = GetStringFromCommand(command);
            long number = Convert.ToInt64(command);
            return number;
        }
        static long GetNumbersFromCommandForInsert(string command)
        {
            command = GetStringFromCommand(command);
            string index = "";
            string element = "";
            long indexToLong = -1;
            int i = 0;
            while (command[i] != ' ')
            {
                element += command[i];
            }
            return indexToLong;

        }
        static void Main(string[] args)
        {
            //List<long> numbers = new List<long>()
            //{
            //    1,2,3,4,5,5,5
            //};
            //numbers.RemoveAll(t=>t==5);
            //numbers.Insert(1, 10);
            //Console.WriteLine(string.Join(" ",numbers));
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string[] commands; 
            do
            {
                //command = Console.ReadLine();
                //command = GetStringFromCommand(command);
                commands = Console.ReadLine().Split(' ').ToArray();
                switch (commands[0])
                {
                    case "Delete":
                        {
                            //string[] commands = commands.Split();
                            int number = int.Parse(commands[1]);
                            numbers.RemoveAll(t => t == number);
                        }
                        break;
                    case "Insert":
                        {
                            int num = int.Parse(commands[1]);
                            int pos = int.Parse(commands[2]);
                            numbers.Insert(pos, num);
                        }
                        break;
                    default:
                        {
                            if (commands[0] == "Odd")
                            {
                                foreach (var item in numbers)
                                {
                                    if (item % 2 == 1)
                                    {
                                        Console.Write($"{item} ");
                                    }
                                }
                                break;
                            }
                            if (commands[0] == "Even")
                            {
                                foreach (var item in numbers)
                                {
                                    if (item % 2 == 0)
                                    {
                                        Console.Write($"{item} ");
                                    }
                                }
                                break;
                            }
                        }
                        break;
                }

            } while (commands[0]!= "Odd" && commands[0]!="Even");   
        }
    }
}
