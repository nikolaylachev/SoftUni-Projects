using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_War
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosAttackDamage = int.Parse(Console.ReadLine());
            int goshosAttackDamege = int.Parse(Console.ReadLine());
            int goshosHealth = 100, peshosHealth = 100;
            int roundCounter = 0;
            do
            {
                roundCounter++;


                if (roundCounter % 2 == 1 )//Odd - Pesho attacks
                {
                      goshosHealth -= peshosAttackDamage;
                    if (goshosHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health."); 
                    } 
                }
                else if (roundCounter % 2 == 0 )//Even - Gosho attacks
                {
                    peshosHealth -= goshosAttackDamege;
                    if (peshosHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");  
                    }
                }

                if (peshosHealth <= 0 && goshosHealth > 0)
                {
                    Console.WriteLine($"Gosho won in {roundCounter}th round.");
                    break;
                }
                if (goshosHealth <= 0 && peshosHealth > 0)
                {
                    Console.WriteLine($"Pesho won in {roundCounter}th round.");
                    break;
                }

                if (roundCounter % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }

             
            } while ((goshosHealth > 0) && (peshosHealth > 0));
        }
    }
}
