using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterVal = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int notCounter = 0;
            int counter = 0;
            int i = 0, j = 0;
            for (i = startOfInterval; i <= endOfInterVal; i++)
            {

                for (j = startOfInterval; j <= endOfInterVal; j++)
                {
                    counter++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, magicNumber);
                      break;
                    }
                    else if ((i + j) != magicNumber)
                    {
                        notCounter++;
                    }
                }

                if ((i + j) == magicNumber)
                {
                    break;
                }
                if ((i+j) != magicNumber)
                {
                    notCounter++;
                }
            }

            if (counter == notCounter)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
                //Console.WriteLine("{0} {1}",counter, notCounter);
            }
            //Console.WriteLine("{0} {1}",counter, notCounter);

        }
    }
}
