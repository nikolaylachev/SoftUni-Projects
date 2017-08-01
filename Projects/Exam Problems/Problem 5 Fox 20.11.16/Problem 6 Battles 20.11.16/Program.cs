using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_Battles_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPokemonsOfP1 = int.Parse(Console.ReadLine());
            int numberOFPokemonsOfP2 = int.Parse(Console.ReadLine());
            int numberOFMaxBattles = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 1; i <= numberOfPokemonsOfP1; i++)
            {
                for (int j = 1; j <= numberOFPokemonsOfP2; j++)
                {
                   
                    Console.Write("({0} <-> {1}) ", i, j);
                    counter++;
                    if (counter == numberOFMaxBattles)
                    {
                        break;
                    }
                }
                if (counter==numberOFMaxBattles)
                {
                    break;
                }
            }
            //Console.WriteLine(counter);
        }
    }
}
