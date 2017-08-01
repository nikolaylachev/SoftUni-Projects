using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karoke
{
    class Program
    {
        class Participant
        {
            public string Name { get; set; }
            public List<string> Awards { get; set; }
            public int AwardsCount { get; set; }
        }

        static void Main(string[] args)
        {
            string[] allNames = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] allSongs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();

            ///List<Participant> participants = new List<Participant>();

            Dictionary<string, List<string>> awardsByPlayer = new Dictionary<string, List<string>>();
            foreach (var player in allNames)
            {
                awardsByPlayer[player] = new List<string>(); //Initializing every person with a empty list of awards.
            }

           //Add information about the people in the dictionary from the commands.

            do
            {
                string command = Console.ReadLine();
                if (command!= "dawn")
                {
                    var tokens = Regex.Split(command, @"\s*,\s*");
                    var player = tokens[0];
                    var song = tokens[1];
                    var award = tokens[2];
                    if (allSongs.Contains(song) && allNames.Contains(player))
                    {
                        awardsByPlayer[player].Add(award); 
                    }
                   
                }
                else if (command == "dawn")
                {
                    break;
                }
            } while (true);

            //Print the results
            var result = awardsByPlayer.
                Select(item => new 
                {
                    playerName = item.Key,
                    awards = item.Value.Distinct(),//.OrderBy(a => a),//OrderBy -> Can be done at line 71!!! 
                    awardsCount = item.Value.Distinct().Count(),
                })
                .OrderByDescending(p => p.awardsCount)
                .ThenBy(p => p.playerName)
                .Where(p => p.awardsCount > 0)
                .ToArray();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.playerName}: {item.awardsCount} awards");
                foreach (var aw in item.awards.OrderBy(x => x))//comment from line 60: item.awards.OrederBy(a => a)
                {
                    Console.WriteLine($"--{aw}");
                }
            }

            if (result.Length == 0)
            {
                Console.WriteLine("No awards");
            }

            /*List<int> myList = new List<int>() { 2, 5, 7, 13, 8 };

            var result = myList.Select(p => p * p)
                .Where(item => item % 2 == 0)
               .OrderByDescending(item => item);

            Console.WriteLine(string.Join(", ",result));*/
        }
    }
}
