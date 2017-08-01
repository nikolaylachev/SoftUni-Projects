using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulation
{
    class Program
    {
        static List<long> SumPairs(List<long> numbers)
        {
            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                }
            }
            else if (numbers.Count % 2 ==1)
            {
                for (int i = 0; i < numbers.Count-1; i++)
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                }
            }
            return numbers;
        }
        static List<long> LeftShift(List<long> numbers, string positions)
        {
            int pos = int.Parse(positions);
            long copyOfFirstElement = numbers[0];
            for (int i = 1; i <= pos; i++)
            {
                copyOfFirstElement = numbers[0];
                numbers.RemoveAt(0);
                numbers.Insert(numbers.Count, copyOfFirstElement); 
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string[] commands;
            do
            {
                commands = Console.ReadLine().Split(' ').ToArray();
                switch (commands[0])
                {
                    case "add":
                        {
                            int index = int.Parse(commands[1]);
                            if (index >= 0)
                            {
                                long element = long.Parse(commands[2]);
                                numbers.Insert(index, element); 
                            }
                        }
                        break;
                    case "addMany":
                        {
                            int index = int.Parse(commands[1]);
                            if (index >=0)
                            {
                                for (int i = commands.Length - 1; i >= 2; i--)
                                {
                                    long element = long.Parse(commands[i]);
                                    numbers.Insert(index, element);
                                } 
                            }
                        }
                        break;
                    case "contains":
                        {
                            long element = long.Parse(commands[1]);
                            bool isContained = false;
                            int index = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == element)
                                {
                                    isContained = true;
                                    index = i;
                                    break;
                                }
                                else
                                {
                                    //break;
                                }
                            }
                            if (isContained == true)
                            {
                                Console.WriteLine(index);
                            }
                            else
                            {
                                Console.WriteLine("-1");
                            }
                        }
                        break;
                    case "remove":
                        {
                            int index = int.Parse(commands[1]);
                            if (index >= 0)
                            {
                                numbers.RemoveAt(index);
                            }
                           
                        }
                        break;
                    case "shift":
                        {
                            string positions = commands[1];
                            numbers = LeftShift(numbers, positions);
                        }
                        break;
                    case "sumPairs":
                        {  
                            SumPairs(numbers);
                        }
                        break;
                    default:
                        {
                            if(commands[0] == "print")
                            {
                                Console.Write("["); 
                                Console.Write(string.Join(", ",numbers));
                                Console.WriteLine("]");
                                break;
                            }
                        }
                        break;
                }
            } while (commands[0] != "print");
           
        }
    }
}
