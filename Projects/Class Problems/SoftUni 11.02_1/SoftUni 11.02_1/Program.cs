using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_11._02_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //For class:
            /*string row = new string('*', 10);//Very important!
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(row);
            }*/

            //Valio's solution for Problem 5
            /*
            int n = int.Parse(Console.ReadLine());
            
            string middle = new string('-', n - 2);
            string temp = "";

            for (int i = 0; i < middle.Length; i++)
            {
                temp += " ";
                temp += middle[i];
            }
            Console.WriteLine("+{0} +",temp);
            for (int i = 1; i < n-2; i++)
            {
                Console.WriteLine("|{0} |",temp);
            }
            Console.WriteLine("+{0} +", temp);*/

            //Problem 6 Mine algorithm.
            /*int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                
                Console.Write(new string(' ',n-row));
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string(' ', 1));
                }
               Console.WriteLine();
            }

            for (int row2 = n-1; row2 >= 1; row2--)
            {
                Console.Write(new string(' ', n-row2));
                for (int j = row2; j >=1; j--)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string(' ', 1));
                }
                Console.WriteLine();
            }*/

        }
    }
}
