using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static bool CheckingMessage(string licencePlate)
        {
            bool isPlateValid = false;
            int firstPartCounter = 0;
            int middlePartCounter = 0;
            int thirdPartCounter = 0;
            if (licencePlate.Length==8)
            {
                for (int i = 0,j=6; i < 2; i++,j++)
                {
                    if (licencePlate[i] >='A' && licencePlate[i]<='Z')
                    {
                        firstPartCounter++;
                    }
                    if (licencePlate[j] >='A' && licencePlate[j] <= 'Z')
                    {
                        thirdPartCounter++;
                    }
                }
                for (int i = 2; i <= 5; i++)
                {
                    if (licencePlate[i] >= '0' && licencePlate[i] <='9')
                    {
                        middlePartCounter++;
                    }
                }
                if (firstPartCounter == 2 && middlePartCounter==4 && thirdPartCounter == 2)
                {
                    isPlateValid = true;
                    return isPlateValid;
                }
                else
                {
                    isPlateValid = false;
                    return isPlateValid;
                }
            }
            else if (licencePlate.Length != 8)
            {
               isPlateValid = false;
                return isPlateValid;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            List<string> command = new List<string>();
            Dictionary<string, string> licencePlates = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            bool isValid = false;
            for (int i = 1; i <= n; i++)
            {
                command = Console.ReadLine().Split(' ').ToList();
                switch (command[0])
                {
                    case"register":
                        {
                            if (!licencePlates.ContainsKey(command[1]))
                            {
                                if (!licencePlates.ContainsValue(command[2]))
                                {
                                    isValid = CheckingMessage(command[2]);
                                    if (isValid == true)
                                    {
                                        licencePlates[command[1]] = command[2];
                                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                                    }
                                    else if (isValid == false)
                                    {
                                        Console.WriteLine($"ERROR: invalid license plate {command[2]}");
                                    } 
                                }

                                else if (licencePlates.ContainsValue(command[2]))
                                {
                                    Console.WriteLine($"ERROR: license plate {command[2]} is busy");
                                }
                            }
                            else if (licencePlates.ContainsKey(command[1]))
                            {
                                if (!licencePlates.ContainsValue(command[2]))
                                {
                                    Console.WriteLine($"ERROR: already registered with plate number {licencePlates[command[1]]}");
                                }
                            }
                        }
                        break;
                    case "unregister":
                        {
                            if (!licencePlates.ContainsKey(command[1]))
                            {
                                Console.WriteLine($"ERROR: user {command[1]} not found");
                            }
                            else if (licencePlates.ContainsKey(command[1]))
                            {
                                Console.WriteLine($"user {command[1]} unregistered successfully");
                                licencePlates.Remove(command[1]);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in licencePlates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            Console.WriteLine(Math.Round(125.33));
        }
    }
}
