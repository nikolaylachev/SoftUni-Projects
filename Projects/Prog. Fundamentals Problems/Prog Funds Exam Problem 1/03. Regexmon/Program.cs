using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string didimonPattern = @"[^a-zA-Z\-]+";
            string bojomonPattern = @"([a-zA-Z]+)\-([a-zA-Z]+)";

            while (true)
            {
                var didimonMatch = Regex.Match(inputLine, didimonPattern);

                if (didimonMatch.Success)
                {
                    Console.WriteLine(didimonMatch.Value);
                    inputLine = inputLine.Remove(0, (didimonMatch.Index + didimonMatch.Value.Count()));
                }
                else if (!didimonMatch.Success)
                {
                    break;
                }

                var bojomonMatch = Regex.Match(inputLine, bojomonPattern);

                if (bojomonMatch.Success)
                {
                    Console.WriteLine(bojomonMatch.Value);
                    inputLine = inputLine.Remove(0, bojomonMatch.Index + bojomonMatch.Value.Count());
                }
                else if (!bojomonMatch.Success)
                {
                    break;
                }
            }

        }
    }
}
