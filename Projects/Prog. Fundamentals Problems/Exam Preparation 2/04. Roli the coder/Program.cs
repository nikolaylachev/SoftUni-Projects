using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.Roli_the_coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> events = new Dictionary<string, List<string>>();

            Dictionary<string,string> idsAndEventsNamedict = new Dictionary<string, string>();

            do
            {
                string command = Console.ReadLine();

                if (command != "Time for Code")
                {
                    var tokens = Regex.Split(command, @"[\s]+");

                    if (tokens[1].Contains("#"))
                    {
                        var ID = tokens[0];
                        var eventName = tokens[1];

                        if (!idsAndEventsNamedict.ContainsKey(tokens[0]) && !idsAndEventsNamedict.ContainsValue(tokens[1]))
                        {
                            idsAndEventsNamedict.Add(tokens[0], tokens[1]);

                            List<string> participants = tokens.Skip(2).Take(tokens.Length - 2).ToList();

                            if (!events.ContainsKey(tokens[1]))
                            {
                                events.Add(tokens[1], participants);
                            }

                            else if (events.ContainsKey(tokens[1]) && !events.ContainsValue(participants))
                            {
                                for (int i = 0; i < participants.Count; i++)
                                {
                                    events[tokens[1]].Add(participants[i]); 
                                }
                              events[tokens[1]].Distinct();
                            }

                            participants = new List<string>();
                        }
                        else if (idsAndEventsNamedict.ContainsKey(tokens[0]) && !idsAndEventsNamedict.ContainsValue(tokens[1]))
                        {

                        }
                        else if (idsAndEventsNamedict.ContainsKey(tokens[0]) && idsAndEventsNamedict.ContainsValue(tokens[1]))
                        {
                            
                            List<string> participants = tokens.Skip(2).Take(tokens.Length - 2).ToList();
                            if (!events.ContainsKey(tokens[1]))
                            {
                                //tokens[1] = tokens[1].Skip(1).Take(tokens[1].Length - 1).ToString();
                                events.Add(tokens[1], participants);
                            }
                            else if (events.ContainsKey(tokens[1]) && !events.ContainsValue(participants))
                            {
                                for (int i = 0; i < participants.Count; i++)
                                {
                                    events[tokens[1]].Add(participants[i]);
                                }
                                events[tokens[1]].Distinct();
                            }

                            participants = new List<string>();
                        }


                    }

                    else if(!tokens.Contains("#"))
                    {
                        //break;
                    }
                }

                else if (command == "Time for Code")
                {
                    break;
                }

            } while (true);

            var result = events
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Value).ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in result)
            {

                string key = item.Key;
                //Console.WriteLine(key);
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == '#')
                    {
                        key = key.Remove(i, 1);
                    }
                }
                //Console.WriteLine(key);
                Console.WriteLine($"{key} - {item.Value.Count}");
                foreach (var value in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"{value}"); 
                }
            }
        }
    }
}
