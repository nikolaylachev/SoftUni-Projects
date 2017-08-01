using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, int> amountOfCharacterNeeded = new Dictionary<string, int>();
            
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                amountOfCharacterNeeded[command[0]] = int.Parse(command[1]);

                //[*]{10,}
                string pattern = $"[{command[0]}]{{{command[1]},}}";
                Regex regex = new Regex (pattern);
                Match match = regex.Match(text);

                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                    break;
                }
                else
                {
                    command = new List<string>();
                    amountOfCharacterNeeded = new Dictionary<string, int>();
                }

            }
        }
    }
}
