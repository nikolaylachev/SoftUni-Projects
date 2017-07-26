using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {


            var input = Console.ReadLine().ToUpper();
            var matches = Regex.Matches(input, @"(\D+)(\d+)");
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                var text = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(text);
                }

            }
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);

            /*
            string message = Console.ReadLine();
            string splitPattern = @"[^0-9\n\r\t]+\d{1,2}";
            string countPattern = @"\d{1,2}?";

            List<string> matchesList = new List<string>();
            List<int> counts = new List<int>();
            List<string> newMatchesList = new List<string>(matchesList.Count);

            MatchCollection matches = Regex.Matches(message,splitPattern);

            int uniqueCharactersCounter = 0;

            //Adding every 
            foreach (Match match in matches)
            {
                matchesList.Add(match.ToString());
                //Console.WriteLine(match);
            }

            for (int i = 0; i < matchesList.Count; i++)
            {
                matchesList[i] = matchesList[i].ToUpper();

              

                MatchCollection countMatches = Regex.Matches(matchesList[i], countPattern);

                foreach (Match countMatch in countMatches)
                {
                    counts.Add(int.Parse(countMatch.ToString()));
                }

                matchesList[i] = Regex.Replace(matchesList[i], @"[\d]{1,2}", string.Empty);

                newMatchesList.Add(matchesList[i]);

                for (int j = 1; j <= counts[i]-1; j++)
                {
                    newMatchesList[i] += matchesList[i];
                }

            }

            //Distincing the message.
            string commandWithoutNumbers = Regex.Replace(message, @"[\d]{1,2}", string.Empty);
            commandWithoutNumbers = commandWithoutNumbers.ToUpper();
            commandWithoutNumbers = new String(commandWithoutNumbers.Distinct().ToArray());

            uniqueCharactersCounter = commandWithoutNumbers.Length;

            //Print the results.
            Console.WriteLine($"Unique symbols used: {uniqueCharactersCounter}");

            foreach (var match in newMatchesList)
            {
                Console.Write(match);
            }
            Console.WriteLine();
            */
        }
    }
}
