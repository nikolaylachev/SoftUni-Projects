using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(^|(?<=\s)([a-z0-9]*[.\-_]?[a-z0-9]+)+@([a-z-]+([.][a-z-]+)+)\b";//\b(\w*[.\-_]?\w+)+@([a-z-]+([.][a-z-]+)+)\b -> remade - Not working
            string input = Console.ReadLine();// \b([a-z0-9]*[.\-_]?\w+)+@([a-z-]+([.][a-z-]+)+)\b -> remade 2-nd time - Not working

            var emails = Regex.Matches(input, regex);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
