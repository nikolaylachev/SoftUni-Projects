using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static int GetIndexFromCommand(string command)
        {
            string indexToLong = string.Empty;
            int index = -1;
            int i = 0;
            while (command[i] != ' ' )//&& (command[i] >= '0' && command[i] <= '9'))
            {
                indexToLong += command[i];
                i++;
            }

            try
            {
                index = Convert.ToInt32(indexToLong);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }

                if (command.Contains('-'))
                {
                    //return index * -1;
                }
                else
                {
                    return index;
                }
            return index; 
            }
        

        static string GetStringFromCommand(string command)
        {
            string stringPart = string.Empty;
            int i = 0;

            while (command[i] != ' ')
            {
                i++;
            }
            command = command.Remove(0, i+1);
            for ( i = 0; i < command.Length; i++)
            {
                //if ((command[i] >= 'a' && command[i] <= 'z') || (command[i] >= 'A' && command[i] <= 'Z') 
                //    || (command[i] >= '0' && command[i] <= '9') || command[i] == '-')
                {
                    stringPart += command[i];
                }
            }
            return stringPart;
        }

        static string RemovingReplaceFromCommand(string command)
        {
            string stringPart = string.Empty;
            if (command.Contains("Replace"))
            {
                command = command.Remove(0, 8);
            }
            return command;
        }

        static void Main(string[] args)
         {
            //long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] arr = Console.ReadLine().Split().ToArray();
            List<string> stringList = new List<string>();
            string command = string.Empty;
            //int n = int.Parse(Console.ReadLine());
            string replacingString = string.Empty;
            long newIndex = 0L;
            

            for (int i = 0; i < arr.Length; i++)
            {
                stringList.Add(arr[i]);
            }
           do//for (int i = 1; i <= n; i++)//do
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "Distinct":
                        {
                            stringList = stringList.Distinct().ToList();
                        }
                        break;
                    case "Reverse":
                        {
                            stringList.Reverse();
                        }
                        break;
                    
                    default:
                        {
                            if (command[0] =='R' && command[1] == 'e' && command[2] == 'p' && command[3] == 'l'
                                && command[4] == 'a' && command[5] == 'c' && command[6] == 'e')
                            {
                                command = RemovingReplaceFromCommand(command);
                                newIndex = GetIndexFromCommand(command);
                                if (newIndex >= 0 && newIndex <= stringList.Count-1)
                                {
                                    replacingString = GetStringFromCommand(command);
                                    stringList.RemoveAt((int)newIndex);
                                    stringList.Insert((int)newIndex, replacingString);  
                                }
                                else if(newIndex < 0 || newIndex > stringList.Count-1)
                                {
                                    Console.WriteLine("Invalid input!");
                                }

                            }
                            else if(command != "END")
                            {
                               Console.WriteLine("Invalid input!");
                            }
                        }
                        break;
                }
            }
            while (command != "END") ;

            string lastElementInList = stringList[stringList.Count - 1];

            foreach (string item in stringList)
            {
                if (item != lastElementInList)
                {
                    Console.Write($"{item}, ");  
                }
                else if (item == lastElementInList)
                {
                    Console.Write($"{item} ");
                }
            }
            //Console.WriteLine();
        }
    }
}
