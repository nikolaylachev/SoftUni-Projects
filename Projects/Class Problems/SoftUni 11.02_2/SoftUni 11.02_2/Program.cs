using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_11._02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 7 - Christmas tree.
            /*int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string stars = new string('*', i);
                string spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine(spaces);
            }*/
            //Problem 8 - Sun Glasses.
            /*int n = int.Parse(Console.ReadLine());
            string star = new string('*',2*n);
            string space = new string(' ', n);
            string line = new string('/', (2 * n) - 2);

            Console.Write(star);
            Console.Write(space);
            Console.WriteLine(star);
            for (int i = 1; i <= n-2; i++)
            {
                
                if (i==(n-1)/2)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(line);
                    Console.Write(new string('*', 1));
                    Console.Write(new string('|',n));
                    Console.Write(new string('*', 1));
                    Console.Write(line);
                    Console.WriteLine(new string('*', 1));
                }
                else
                {
                    Console.Write(new string('*', 1));
                    Console.Write(line);
                    Console.Write(new string('*', 1));
                    Console.Write(space);
                    Console.Write(new string('*', 1));
                    Console.Write(line);
                    Console.WriteLine(new string('*', 1));
                }
            }
            Console.Write(star);
            Console.Write(space);
            Console.WriteLine(star);*/

            //Problem 10 - Slav's solution.--Half complete
            /*int n = int.Parse(Console.ReadLine());
            int starsInTop;
            if (n%2==1)
            {
                starsInTop = 1;
            }
            else
            {
                starsInTop = 2;
            }

            int numberOfDashesInTop = (n - starsInTop)/2;
            Console.WriteLine("{0}{1}{0}",new string('-',numberOfDashesInTop),new string('*',starsInTop));//

            int numberOfDashesBetweenStars;
            if (n%2==1)
            {
                numberOfDashesBetweenStars = 1;
            }
            else
            {
                numberOfDashesBetweenStars = 2;
            }

            int numberOfDashesPerSide = (n - 2 - numberOfDashesBetweenStars) / 2;
            int upperPartHeigth;
            if (n%2==1)
            {
                upperPartHeigth = n / 2;
            }
            else
            {
                upperPartHeigth = n / 2 - 1;
            }

            for (int i = 0; i < upperPartHeigth; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('-',numberOfDashesPerSide), new string('-',numberOfDashesBetweenStars));
                numberOfDashesPerSide--;
                numberOfDashesBetweenStars += 2;
            }


            Console.WriteLine("{0}{1}{0}", new string('-', numberOfDashesInTop), new string('*', starsInTop));*/

            //Problem 9- Slav's solution(Roof only!).
            /*int n = int.Parse(Console.ReadLine());

            int starsPerRowInRoof;
            if (n % 2 == 1)
            {
                starsPerRowInRoof = 1;
            }
            else
            {
                starsPerRowInRoof = 2;
            }

            int numberOfDashesPerSideInRoof = (n - starsPerRowInRoof) / 2;

            int roofHeigth;
            if (n % 2 == 1)
            {
                roofHeigth = n / 2 + 1;
            }
            else
            {
                roofHeigth = n / 2; 
            }
            for (int i = 0; i < roofHeigth; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('-',numberOfDashesPerSideInRoof),new string('*', starsPerRowInRoof));
                numberOfDashesPerSideInRoof--;
                starsPerRowInRoof += 2;
            }
           //My part.
            string dash = new string('|',1);
            string star = new string('*', n-2);
            for (int i = 1; i <= n/2; i++)
            {
                Console.Write(dash);
                Console.Write(star);
                Console.WriteLine(dash);

            }
            */

        }
    }
}
