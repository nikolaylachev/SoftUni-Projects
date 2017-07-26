using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        class Pokemon
        {
           // public string Name { get; set; }
            public string EvolutionType { get; set; }
            public int EvolutionIndex { get; set; }
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<Pokemon>> pokemons = new Dictionary<string, List<Pokemon>>();
            while (true)
            {
                string line = Console.ReadLine();
                string fullCommandPattern = @"(?<pokemonName>[^\s\-\>]+)(\s*->\s*(?<evolutionType>[^\s\-\>]+)\s*->\s*(?<evolutionIndex>\d+))";//@"(?<pokemonName>[a-zA-Z]+)(\s*->\s*(?<evolutionType>[a-zA-Z]+)\s*->\s*(?<evolutionIndex>\d+))";
                string nameOnlyPattern = @"^(?<nameOnly>[^\s\-\>]+)$";//@"^(?<nameOnly>[a-zA-Z]+)$";



                if (line== "wubbalubbadubdub")
                {
                    break;
                }

                else if(line != "wubbalubbadubdub")
                {
                    Match fullNameMatch = Regex.Match(line, fullCommandPattern);
                    
                    if (fullNameMatch.Success)
                    {
                        var pokemonName = new string(fullNameMatch.Groups["pokemonName"].Value.ToArray());
                        var evolutionType = new string(fullNameMatch.Groups["evolutionType"].Value.ToArray());
                        var evolutionIndex = new string(fullNameMatch.Groups["evolutionIndex"].Value.ToArray());

                            if (!pokemons.ContainsKey(pokemonName))
                            {
                                pokemons[pokemonName] = new List<Pokemon>()
                                {
                                    new Pokemon()
                                    {
                                        EvolutionType = evolutionType,
                                        EvolutionIndex = int.Parse(evolutionIndex),
                                    }
                                };
                            }

                            else if (pokemons.ContainsKey(pokemonName))
                            {
                                Pokemon pokemon = new Pokemon()
                                {

                                    EvolutionType = evolutionType,
                                    EvolutionIndex = int.Parse(evolutionIndex),
                                };

                                pokemons[pokemonName].Add(pokemon);

                            } 
                        

                        }
                        else if (!fullNameMatch.Success)
                        {

                            Match nameOnlyMatch = Regex.Match(line, nameOnlyPattern);

                            if (nameOnlyMatch.Success)
                            {
                                var pokemonNameToString = new string (nameOnlyMatch.Groups["nameOnly"].Value.ToArray());
                                if (pokemons.ContainsKey(pokemonNameToString))
                                { 
                                    Console.WriteLine($"# {pokemonNameToString}");

                                    foreach (var pokemon in pokemons[pokemonNameToString])
                                    {
                                        Console.WriteLine($"{pokemon.EvolutionType} <-> {pokemon.EvolutionIndex}");
                                    }
                                }
                                
                            }
                     }

                 }
            }

           // var result = pokemons;
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var value in pokemon.Value.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{value.EvolutionType} <-> {value.EvolutionIndex}");
                }
            }
        }
    }
}
