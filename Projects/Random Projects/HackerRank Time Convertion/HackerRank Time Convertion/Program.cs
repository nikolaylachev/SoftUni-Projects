using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HackerRank_Time_Convertion
{
    class Program
    {
        static string timeConversion(string s)
        {
            // Complete this function\
            var newTime = "";
            string pattern = @"^(?<hours>\d{2})\:(?<minutes>\d{2})\:(?<seconds>\d{2})(?<type>AM|PM)$";
            Match match = Regex.Match(s, pattern);
            if (match.Success)
            {
                var hours = new string(match.Groups["hours"].Value.ToArray());
                var minutes = new string(match.Groups["minutes"].Value.ToArray());
                var seconds = new string(match.Groups["seconds"].Value.ToArray());
                var type = new string(match.Groups["type"].Value.ToArray());

                
                if (int.Parse(hours)>=0 && int.Parse(hours)<=12
                    && int.Parse(minutes)>=0 && int.Parse(minutes)<=59
                    && int.Parse(seconds) >=0 && int.Parse(minutes)<=59)
                {
                    if (type == "AM")
                    {
                        if (int.Parse(hours) == 12)
                        {
                            newTime = $"{0:d2}:{minutes:d2}:{seconds:d2}";
                        }
                        else
                        {
                            newTime = $"{hours:d2}:{minutes:d2}:{seconds:d2}";
                        }
                       
                    }
                    else if (type == "PM")
                    {
                        if (int.Parse(hours) == 12)
                        {
                            newTime = $"12:{minutes:d2}:{seconds:d2}";
                        }
                        else if(int.Parse(hours) < 12)
                        {
                            newTime = $"{(int.Parse(hours) + 12):d2}:{minutes:d2}:{seconds:d2}";  
                        }
                    }
                }
            }
        
            return newTime;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
