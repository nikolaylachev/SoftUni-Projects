using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_two_values
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static char GetMax (char firstCharacter, char secondCharacter)
        {
            if (firstCharacter > secondCharacter)
            {
                return firstCharacter;
            }
            else
            {
                return secondCharacter;
            }
        }

        static string GetMax(string s1, string s2)
        {
            if (s1.CompareTo(s2) > 0)
            {
                return s1;
            }
            else
            {
                return s2;
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(first,second));
                    }
                    break;
                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        Console.WriteLine(GetMax(first, second));
                    }
                    break;
                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        Console.WriteLine(GetMax(first,second));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
