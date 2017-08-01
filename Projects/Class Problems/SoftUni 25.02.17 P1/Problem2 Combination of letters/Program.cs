using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Combination_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char startingLetter = char.Parse(Console.ReadLine());
            char endingLetter = char.Parse(Console.ReadLine());
            char breakingLetter = char.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            for (char firstLetter = startingLetter; firstLetter <= endingLetter; firstLetter++)
            {
                for (char secondLetter = startingLetter; secondLetter <= endingLetter; secondLetter++)
                {
                    for (char thirdLetter = startingLetter; thirdLetter <= endingLetter; thirdLetter++)
                    {
                        if (firstLetter==breakingLetter || secondLetter==breakingLetter || thirdLetter== breakingLetter )
                        {
                            continue;
                        }
                        else
                        {
                            combinationsCounter++;
                            Console.Write("{0}{1}{2} ",firstLetter,secondLetter,thirdLetter);
                        }
                    
                    }
                }
            }
            Console.WriteLine("{0}",combinationsCounter);
        }
    }
}
