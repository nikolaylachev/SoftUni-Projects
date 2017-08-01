using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02.Command_Interpreter
{
    

    class Program
    {
        static List<int> GetReversedArray(List<int> arr, int start, int count)
        {
            int iterator = 0;

            while (true)
            {
                int firstElement = arr[start + iterator];

                arr[start + iterator] = arr[(start+count - 1) - iterator];
                arr[(start + count - 1) -iterator] = firstElement;
                iterator++;

                if (iterator >= (start + count - 1) / 2)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            return arr;
        }



        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();

            string pattern = @"[\s]+";
            var numbersString = Regex.Split(input, pattern).ToList();

            foreach (var item in numbersString)
            {
                numbers.Add(int.Parse(item));
            }

            string mainCommand = "";

            do
            {
                mainCommand = Console.ReadLine();

                if (mainCommand != "end")
                {
                    var tokens = mainCommand.Split(' ').ToArray();
                    var command = tokens[0];

                    switch (tokens[0])
                    {
                        case "reverse":
                            {
                                var start = int.Parse(tokens[2]);
                                var count = int.Parse(tokens[4]);

                                if (start < 0 || start >= numbers.Count || count < 0)
                                {
                                    Console.WriteLine("Invalid input parameters.");
                                    break;
                                }

                                else
                                {
                                    numbers = GetReversedArray(numbers, start, count);
                                }

                            }
                            break;

                        case "sort":
                            {
                                var start = int.Parse(tokens[2]);
                                var count = int.Parse(tokens[4]);

                                if (start < 0 || start >= numbers.Count || count < 0)
                                {
                                    Console.WriteLine("Invalid input parameters.");
                                    break;
                                }

                                else
                                {
                                    var subArray = numbers.GetRange(start, count);

                                    subArray.Sort();
                                    numbers.RemoveRange(start, count);
                                    numbers.InsertRange(start, subArray);
                                }

                            }
                            break;

                        case "rollLeft":
                            {
                                var count = int.Parse(tokens[1]);
                                if ( count < 0)
                                {
                                    Console.WriteLine("Invalid input parameters.");
                                    break;
                                }
                            }
                            break;

                        case "rollRight":
                            {
                                var count = int.Parse(tokens[1]);
                                if (count < 0)
                                {
                                    Console.WriteLine("Invalid input parameters.");
                                    break;
                                }
                            }
                            break;
                        default:
                            break;
                    }

                }
                else if (mainCommand == "end")
                {
                    break;
                }

            } while (true);

            Console.WriteLine(string.Join(" ",numbers));
            

        }
    }
}
