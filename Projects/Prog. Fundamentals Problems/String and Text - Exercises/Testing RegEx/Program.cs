using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Testing_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string regex = @"\b[A-Z]{1}[a-z]+\s{1}[A-Z]{1}[a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names,regex);

            foreach (Match name in matchedNames)
            {
                Console.Write($"{name.Value} ");
            }
            Console.WriteLine();
            */

            // (\+359)([" ""\-"])[2]{1}\2\d{3}\2\d{4}\b ----> \2 - backrefernce to group
            //string regex = @"(\+359)([' ''\-'])[2]{1}\2\d{3}\2\d{4}\b";//regex pattern for second problem

            //Third problem 
            /* string regex = @"\b(?:0x)?([0-9A-F])+\b";
             var numbersString = Console.ReadLine();

             var numbers = Regex.Matches(numbersString, regex)
                 .Cast<Match>()
                 .Select(a => a.Value.Trim())
                 .ToArray();
             Console.WriteLine(string.Join(", ",numbers));
             */

            //4 problem - Match Dates
            /*var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var dateStrings = Console.ReadLine();

            var dates = Regex.Matches(dateStrings, regex);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
            */

            //Problem 5 - Mtch number
            /*var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numberStrings = Console.ReadLine();

            var numbers = Regex.Matches(numberStrings, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();*/

            Console.WriteLine(Regex.Replace("Nakov: 123",@"\d{3}","***"));
        }
    }
}
