using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _18.Sequence_of_Commands
{
    class Program
    {
       
        
        static string CommandToStringOnly(string original)//My function for getting the command's characters only.
        {
            string stringOnly = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] >= 'a' && original[i] <= 'z')
                {
                    stringOnly += original[i];
                } 
            }
            return stringOnly;
        }
        static string CommandToIntOnly(string original)//From stack-overflow: https://stackoverflow.com/questions/6361986/how-get-integer-only-and-remove-all-string-in-c-sharp
        {
            string output = Regex.Replace(original, "[^0-9]+ ", string.Empty);//Added space " " because otherwise it would work!
            return output;

        }

        private const char ArgumentsDelimiter = ' ';
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();
            string copy = command;
            command = CommandToStringOnly(command);
            

            while (!command.Equals("stop"))
            {
                string line = CommandToIntOnly(copy).Trim();
                int[] args = new int[2];
               

                if (command.Equals("add") ||
                    command.Equals("subtract") ||//it was substract!!!
                    command.Equals("multiply"))
                {
                    //string line = Console.ReadLine().Trim();
                    //int[] args = new int[2];
                    string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[0]);
                    args[1] = int.Parse(stringParams[1]);

                    PerformAction(array, command, args);
                }

                else
                {
                    //PerformAction(array, command, args); 
                    PerformShiftingAction(array, command);
                }

                PrintArray(array);
               // Console.WriteLine('\n');

                command = Console.ReadLine();
                copy = command;
                command = CommandToStringOnly(command);
            }
        }
        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos-1] *= value;
                    break;
                case "add":
                    arr[pos-1] += value;
                    break;
                case "subtract":
                    arr[pos-1] -= value;
                    break;
                //case "lshift":              Made another function for left shifting.
                //    ArrayShiftLeft(arr);
                //    break;
                //case "rshift":
                //    ArrayShiftRight(arr);    And for right shifting too.
                //    break;
            }
        }
        private static void PerformShiftingAction(long[] arr, string action)//New function made by me for left and right shifting.
        {
            switch (action)
            {
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
                default:
                    break;
            }
        }
        private static void ArrayShiftRight(long[] array)
        {
            long copyOfLastElement = array[array.Length - 1];//(Made by me.) Copy of last element for assigning it to the last element.
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = copyOfLastElement;//First element takes the value of last element.
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long copyOfFirstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = copyOfFirstElement;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
