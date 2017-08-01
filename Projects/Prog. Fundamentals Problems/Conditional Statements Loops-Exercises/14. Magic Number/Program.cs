using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char startingLetter = char.Parse(Console.ReadLine());
             char endingLetter = char.Parse(Console.ReadLine());
             char notIncludedLetter = char.Parse(Console.ReadLine());
             for (char firstLetter = startingLetter; firstLetter <= endingLetter; firstLetter++)
             {
                 for (char secondLetter = startingLetter; secondLetter <= endingLetter; secondLetter++)
                 {
                     for (char thirdLetter = startingLetter; thirdLetter <= endingLetter; thirdLetter++)
                     {
                         if (firstLetter==notIncludedLetter || secondLetter==notIncludedLetter || thirdLetter==notIncludedLetter)
                         {
                            continue;
                         }
                        Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                    }
                 }
             }
        }
    }
}
