using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        class Score
        {
           // public string Name { get; set; }
            public int Points { get; set; }
            public int Goals { get; set; }
        }

        static void Main(string[] args)
        {
            string key = Regex.Escape(Console.ReadLine());

            string line = "";//({{{specialSymbol}}}([\w]+){{{specialSymbol}}})
            string pattern = string.Format(@"^.*(?:{0})(?<team1>[a-z-A-Z]*)(?:{0}).* .*(?:{0})(?<team2>[a-zA-Z]*)(?:{0}).* (?<team1Goals>\d+):(?<team2Goals>\d+).*$",key);

            Dictionary<string, Score> matches = new Dictionary<string, Score>();//<Name of team, Score props>

            var matchRegex = new Regex(pattern);
            do
            { 
                line = Console.ReadLine();

                if (line!="final")
                {
                    var match = matchRegex.Match(line);

                    var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                    var team2Name = new string (match.Groups["team2"].Value.ToUpper().Reverse().ToArray());

                    var team1Goals = int.Parse(match.Groups["team1Goals"].Value);
                    var team2Goals = int.Parse(match.Groups["team2Goals"].Value);

                    if (!matches.ContainsKey(team1Name))
                    {
                        matches[team1Name] = new Score();
                    }

                    if (!matches.ContainsKey(team2Name))
                    {
                        matches[team2Name] = new Score();
                    }

                    matches[team1Name].Goals += team1Goals;//Goals taken from the command
                    matches[team2Name].Goals += team2Goals;//goals taken from the command

                    if (team1Goals > team2Goals)//team 1 wins team 2 loses
                    {
                        matches[team1Name].Points += 3;//team 2 wins team 1 loses
                    }
                    else if (team1Goals < team2Goals)
                    {
                        matches[team2Name].Points += 3;
                    }
                    else//draw
                    {
                        matches[team1Name].Points += 1;
                        matches[team2Name].Points += 1; 
                    }

                }

                else if (line == "final")
                {
                    break;
                }

            } while (true);

            var leagueStandings = matches.OrderByDescending(x => x.Value.Points)
                .ThenBy(x => x.Key)
                .ToArray();

            Console.WriteLine("League standings:");

            for (int i = 0; i < leagueStandings.Length; i++)
            {
                var currentStanding = leagueStandings[i];
                var country = currentStanding.Key;

                var place = i + 1;
                Console.WriteLine($"{place}. {country} {currentStanding.Value.Points}");
            }

            var Top3Goals = matches
                .OrderByDescending(x => x.Value.Goals)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToArray();

            Console.WriteLine("Top 3 scored goals:");
            foreach (var pair in Top3Goals)
            {
                var country = pair.Key;
                var goals = pair.Value.Goals;

                Console.WriteLine($"- {country} -> {goals}");
            }
        }
    }
}
