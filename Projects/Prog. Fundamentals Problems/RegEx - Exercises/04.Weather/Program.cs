using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z]{2}[0-9]+[\.\,]{1}[0-9]+[a-zA-Z]+\|";
            Regex regex = new Regex (pattern);
            Match match;
            string input = "";

            Dictionary<string, List<string>> weathersByCity = new Dictionary<string, List<string>>();
            List<string> averageTempsAndWeathers = new List<string>();

            string tempsAndWeathersForList = "";
            string key = "";
            string matchToString = "";

            do
            {
                input = Console.ReadLine();
                if (input != "end")
                {
                    match = regex.Match(input);
                    if (match.Success)
                    {

                        matchToString += match;

                        for (int i = 2; i <  match.Length; i++)
                        {
                            tempsAndWeathersForList += matchToString[i]; 
                        }

                        key += matchToString[0];
                        key += matchToString[1]; 

                        averageTempsAndWeathers.Add(tempsAndWeathersForList);

                        if (!weathersByCity.ContainsKey(key))
                        {
                            weathersByCity.Add(key, averageTempsAndWeathers);
                        }

                        else
                        {
                            weathersByCity[key] = averageTempsAndWeathers;
                        }

                        averageTempsAndWeathers = new List<string>();
                        matchToString = "";
                        tempsAndWeathersForList = "";
                        key = "";
                    }

                }

                else if(input == "end")
                {
                    break;
                }

            } while (true);

            foreach (var item in weathersByCity)
            {
                Console.WriteLine(item);
                foreach (var value in weathersByCity.Values)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
