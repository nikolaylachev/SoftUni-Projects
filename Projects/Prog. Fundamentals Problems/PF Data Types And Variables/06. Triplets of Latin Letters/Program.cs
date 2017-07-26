using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triplets_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int firstCharacter = 97; firstCharacter <= (97+number)-1; firstCharacter++)
            {
                for (int secondCharacter = 97; secondCharacter <= (97+number)-1; secondCharacter++)
                {
                    for (int thirdCharacter = 97; thirdCharacter <= (97+number)-1; thirdCharacter++)
                    {
                        Console.WriteLine($"{(char)firstCharacter}{(char)secondCharacter}{(char)thirdCharacter}");
                    }
                }
            }
        }
    }
}
