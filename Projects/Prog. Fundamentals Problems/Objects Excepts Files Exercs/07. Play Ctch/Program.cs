using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Play_Ctch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int counter = 0;
            List<string> command = new List<string>();
            do
            {
                command = Console.ReadLine().Split(' ').ToList();
                switch (command[0])
                {
                    case "Replace":
                        {
                            try
                            {
                                numbers.Insert(int.Parse(command[1]), long.Parse(command[2]));
                                numbers.RemoveAt(int.Parse(command[1]) + 1);
                            }

                            catch (FormatException)
                            {
                                counter++;
                                Console.WriteLine("The variable is not in the correct format!");
                            }

                            catch (ArgumentOutOfRangeException)
                            {
                                counter++;
                                Console.WriteLine("The index does not exist!");
                            }
                        }
                        break;
                    case "Show":
                        {
                            try
                            {
                                Console.WriteLine(numbers[int.Parse(command[1])]);
                            }
                            catch (FormatException)
                            {
                                counter++;
                                Console.WriteLine("The variable is not in the correct format!");
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                counter++;
                                Console.WriteLine("The index does not exist!");
                            }
                        }
                        break;
                    case "Print":
                        {
                            try
                            {
                                if (int.Parse(command[2]) < numbers.Count)
                                {
                                    for (int i = int.Parse(command[1]); i <= int.Parse(command[2]); i++)
                                    {
                                        if (i < int.Parse(command[2]))
                                        {
                                            Console.Write($"{numbers[i]}, ");
                                        }
                                        else if (i == int.Parse(command[2]))
                                        {
                                            Console.WriteLine($"{numbers[i]} ");
                                        }
                                    } 
                                }
                                else if (int.Parse(command[2]) >= numbers.Count)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                            }
                            catch (FormatException)
                            {
                                counter++;
                                Console.WriteLine("The variale is not in the correct format!");
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                counter++;
                                Console.WriteLine("The index does not exist!");
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (counter < 3);
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
