using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string demons = Console.ReadLine();
            string pattern = @"\s*[,]\s*";
            //Regex regex = new Regex (pattern);
            var demonsArray = Regex.Split(demons, pattern).ToArray();

            Dictionary<string, List<double>> demonsDict = new Dictionary<string, List<double>>();
            foreach (var demon in demonsArray)
            {
                demonsDict[demon] = new List<double>();
            }

            string lettersPattern = @"[^0-9\+\-\*\/\.\n \,]+";   //@"[a-zA-Z]+";
            string numbersPattern = @"[\-\+]?(\d+([\.\,]\d+)?)";//@"[\+\-]?\d+[.,]?\d?";
            string specialSymbolPattern = @"[\*\/]+";

           

            foreach (var demon in demonsDict)
            {
                double demonHealth = 0.0D;
                double demonDamage = 0.0D;

                string demonLetters = "";
                string demonNumbers = "";
                string demonSpecialSymbols = "";

                MatchCollection matches  = Regex.Matches(demon.Key, lettersPattern);
                MatchCollection numbersMatches = Regex.Matches(demon.Key, numbersPattern);
                MatchCollection specialSymbols = Regex.Matches(demon.Key, specialSymbolPattern);

                foreach (Match match in matches)
                {
                    demonLetters += match.ToString();
                }
               // Console.WriteLine(demonLetters);
                for (int i = 0; i < demonLetters.Length; i++)
                {
                    demonHealth += (double)demonLetters[i];
                }
                string currentKey = demon.Key.ToString();
                demonsDict[currentKey].Add(demonHealth);//Adds the health to the dictionary

                //Getting damage of demon.
                foreach (Match match in numbersMatches)
                {
                    demonNumbers = match.ToString();
                    demonDamage += double.Parse(demonNumbers);
                }
                //Getting special symbols [*/].
                foreach (Match specsymbol in specialSymbols)
                {
                    demonSpecialSymbols += specsymbol.ToString();
                }

                //Adding their value to the damage.
                for (int i = 0; i < demonSpecialSymbols.Length; i++)
                {
                    if (demonSpecialSymbols[i] == '*')
                    {
                        demonDamage *= 2;
                    }
                    else if (demonSpecialSymbols[i] == '/')
                    {
                        demonDamage /= 2;
                    }

                }
                //Console.WriteLine(demonDamage);
                demonsDict[currentKey].Add(demonDamage);//Adds the demage to the dictionary
                
            }

            //Printing the result
            var result = demonsDict.OrderBy(x => x.Key);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
                //Console.Write($"{item.Key} - ");
                //Console.Write($"{item.Value[0]} health,");
                //Console.WriteLine($" {item.Value[1]:f2} damage.");
            }
        }
    }
}
