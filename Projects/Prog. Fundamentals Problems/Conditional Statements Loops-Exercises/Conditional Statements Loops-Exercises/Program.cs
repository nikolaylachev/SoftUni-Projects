using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements_Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 5. * Word in Plural
            string noun = Console.ReadLine();
            string copyOfNoun = noun;
            for (int i = noun.Length-1; i < noun.Length; i++)
            {
                if (noun[i] == 'y')
                {
                    copyOfNoun = copyOfNoun.Replace("y", string.Empty);// Removing the last element.
                    copyOfNoun += "ies";// Adding "ies" at the end.
                }
                else if ((noun[i]=='o') || (noun[i]=='s') || (noun[i]=='x') || (noun[i]=='z') || (noun[i]=='h' && noun[i-1]=='s') || (noun[i]=='h' && noun[i-1]=='c'))
                {
                    copyOfNoun += "es";
                }
                else
                {
                    copyOfNoun += "s";
                }
            }
            Console.WriteLine(copyOfNoun);
        }
    }
}
