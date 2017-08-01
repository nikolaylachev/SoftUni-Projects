using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 9- Programming Basics/6.Drawing with loops
            /*int n = int.Parse(Console.ReadLine());
            //Roof part
            if (n%2==0)
            {
                int numberOfStarsInRow = 2;
                int numberOfDashesInRow = (n - numberOfStarsInRow) / 2;
                for (int i = 1; i <= (n/2); i++)
                {
                    Console.Write(new string('-',numberOfDashesInRow));
                    Console.Write(new string('*',numberOfStarsInRow));
                    Console.WriteLine(new string('-',numberOfDashesInRow));
                    numberOfStarsInRow += 2;
                    numberOfDashesInRow--;
                }
               
            }
            else if (n%2==1)
            {
                int numberOFStarsInRow = 1;
                int numberOfDashesInRow = (n - numberOFStarsInRow) / 2;
                for (int i = 1; i <= (n / 2) + 1; i++)
                {
                    Console.Write(new string('-', numberOfDashesInRow));
                    Console.Write(new string('*', numberOFStarsInRow));
                    Console.WriteLine(new string('-', numberOfDashesInRow));
                    numberOFStarsInRow += 2;
                    numberOfDashesInRow--;

                }
            }
            //Next part
            for (int i = 1; i <=n/2; i++)
            {
                Console.Write(new string('|',1));
                Console.Write(new string('*',n-2));
                Console.WriteLine(new string('|', 1));
            }*/
            //Problem 10- -||-
            /*int n = int.Parse(Console.ReadLine());
            if (n%2==0)
            {
                if (n > 2)
                {


                    //Top
                    Console.Write(new string('-', (n - 2) / 2));
                    Console.Write(new string('*', 2));
                    Console.WriteLine(new string('-', (n - 2) / 2));
                    //Middle
                    int numberOfMiddleDashes = 2;
                    int numberOfLeftRightDashes = ((n - numberOfMiddleDashes) - 2) / 2;
                    for (int i = 1; i <= (n / 2) - 1; i++)
                    {
                        Console.Write(new string('-', numberOfLeftRightDashes));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', numberOfMiddleDashes));
                        Console.Write(new string('*', 1));
                        Console.WriteLine(new string('-', numberOfLeftRightDashes));
                        numberOfMiddleDashes += 2;
                        numberOfLeftRightDashes--;
                    }
                    numberOfLeftRightDashes = 1;
                    numberOfMiddleDashes = n - 4;
                    for (int i = 1; i <= (n / 2) - 2; i++)
                    {

                        Console.Write(new string('-', numberOfLeftRightDashes));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', numberOfMiddleDashes));
                        Console.Write(new string('*', 1));
                        Console.WriteLine(new string('-', numberOfLeftRightDashes));
                        numberOfLeftRightDashes++;
                        numberOfMiddleDashes -= 2;
                    }



                    //Bottom
                    Console.Write(new string('-', (n - 2) / 2));
                    Console.Write(new string('*', 2));
                    Console.WriteLine(new string('-', (n - 2) / 2));
                }
                else if (n==2)
                {
                    Console.WriteLine(new string('*',2));
                }
            }
            else if (n%2==1)
            {
                if (n > 1)
                {
                    //Top
                    Console.Write(new string('-', n / 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine(new string('-', n / 2));
                    //Middle
                    int numberOfLeftRightDashes = (n - 3) / 2;
                    int numberOfMiddleDashes = 1;
                    for (int i = 1; i <= n / 2; i++)
                    {
                        Console.Write(new string('-', numberOfLeftRightDashes));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', numberOfMiddleDashes));
                        Console.Write(new string('*', 1));
                        Console.WriteLine(new string('-', numberOfLeftRightDashes));
                        numberOfLeftRightDashes--;
                        numberOfMiddleDashes += 2;
                    }

                    numberOfLeftRightDashes = 1;
                    numberOfMiddleDashes = (n - 2) - (2 * numberOfLeftRightDashes);
                    for (int i = 1; i <= (n / 2) - 1; i++)
                    {
                        Console.Write(new string('-', numberOfLeftRightDashes));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', numberOfMiddleDashes));
                        Console.Write(new string('*', 1));
                        Console.WriteLine(new string('-', numberOfLeftRightDashes));
                        numberOfLeftRightDashes++;
                        numberOfMiddleDashes -= 2;
                    }

                    //Bottom
                    Console.Write(new string('-', n / 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine(new string('-', n / 2));
                }
                else if (n==1)
                {
                    Console.WriteLine(new string('*',1));
                }
            }*/
            //Problem from HackersRank
            /*Console.Write("Enter size: ");
            int n = int.Parse(Console.ReadLine());
            int numberOfDollars = 1;
            int numberOfSpaces = n - 1;
            Console.Write("Enter character: ");
            char character = char.Parse(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                Console.Write(new string(' ',numberOfSpaces));
                Console.WriteLine(new string(character,numberOfDollars));
                numberOfDollars++;
                numberOfSpaces--;
            }*/

            //Problem 5 - Programming Basics/6.Drawing with loops.
            /*int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write("+");
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            //Middle
            for (int i = 1; i <= n - 2; i++)
            {

                Console.Write("|");
                for (int row = 1; row <= n - 2; row++)
                {

                    Console.Write(" -");

                }
                Console.WriteLine(" |");
            }
            //Bottom
            Console.Write("+");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");*/
            //Problem 
            /*int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ',n-row));
                for (int i = 1; i <= row; i++)
                {
                   
                    Console.Write("*");
                    Console.Write(" ");
                   
                }
                Console.WriteLine();
            }*/
            //Problem
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write(new string('*',n-2));
            Console.Write(new string('\\',1));
            Console.Write(new string(' ',1));
            Console.Write(new string('/',1));
            Console.WriteLine(new string('*',n-2));

            //Top middle
            for (int i = 1; i <=(n/2)-1; i++)
            {
                Console.Write(new string('-', n - 2));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('/', 1));
                Console.WriteLine(new string('-', n - 2));

                Console.Write(new string('*', n - 2));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('/', 1));
                Console.WriteLine(new string('*', n - 2));
            }
            //Middle
            Console.Write(new string(' ',n-1));
            Console.WriteLine(new string('@',1));

            //Bottom middle
            for (int i = 1; i <= (n/2-1); i++)
            {
                Console.Write(new string('*', n - 2));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('\\', 1));
                Console.WriteLine(new string('*', n - 2));

                Console.Write(new string('-', n - 2));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('\\', 1));
                Console.WriteLine(new string('-', n - 2));
            }
            //Bottom
            Console.Write(new string('*',n-2));
            Console.Write(new string('/',1));
            Console.Write(new string(' ',1));
            Console.Write(new string('\\',1));
            Console.WriteLine(new string('*',n-2));
        }
    }
}
