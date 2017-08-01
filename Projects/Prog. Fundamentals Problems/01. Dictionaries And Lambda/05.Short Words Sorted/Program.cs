using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!
             
            char[] separators = {'.', ',' , ':' , ';' , '(' , ')' , '[' , ']' ,  '\"' , '\'', '\\', '/' , '!', '?' ,' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words.Distinct().Where(word => word.Length < 5).Where(word => word != "").OrderBy(word => word).ToArray();// 

          
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
