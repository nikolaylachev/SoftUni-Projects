using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char characterOfFirstBoat = char.Parse(Console.ReadLine());
            char characterOfSecondBoat = char.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            string speedOfBoats = string.Empty;
            int speedOfFirstBoat = 0;
            int speedOfSecondBoat = 0;
            int totalSpeedOfFirstBoat = 0;
            int totalSpeedOfSecondBoat = 0;
           
            for (byte round = 1; round <= n; round++)
            {
                speedOfBoats = Console.ReadLine();
                if (speedOfBoats != "UPGRADE")
                {
                    if (round % 2 != 0)//Odd round -> first boat
                    {
                        speedOfFirstBoat = speedOfBoats.Length;
                        totalSpeedOfFirstBoat += speedOfFirstBoat;
                        if (totalSpeedOfFirstBoat >= 50)
                        {
                            Console.WriteLine(characterOfFirstBoat);
                            break;
                        }
                    }
                    else if (round % 2 == 0)//Even round -> second boat
                    {
                        speedOfSecondBoat = speedOfBoats.Length;
                        totalSpeedOfSecondBoat += speedOfSecondBoat;
                        if (totalSpeedOfSecondBoat >= 50)
                        {
                            Console.WriteLine(characterOfSecondBoat);
                            break;
                        }
                    } 
                }
                else if (speedOfBoats == "UPGRADE")
                {
                    characterOfFirstBoat = (char)((int)characterOfFirstBoat + 3);
                    characterOfSecondBoat = (char)((int)characterOfSecondBoat + 3);
                }
                if (round == n)
                {
                    if (totalSpeedOfFirstBoat > totalSpeedOfSecondBoat)
                    {
                        Console.WriteLine(characterOfFirstBoat);
                    }
                    else if (totalSpeedOfSecondBoat > totalSpeedOfFirstBoat)
                    {
                        Console.WriteLine(characterOfSecondBoat);
                    }
                }
                
            }

        }
    }
}
