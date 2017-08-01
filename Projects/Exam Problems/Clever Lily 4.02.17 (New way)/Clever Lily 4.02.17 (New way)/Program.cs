using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily_4._02._17__New_way_
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy= int.Parse(Console.ReadLine());

            double moneyFromToys = 0.0D;
            double moneyFromEvenBirthdays = 0.0D;
            double moneyOnEvenBirthdays = 10.00D;
            for (int i = 1; i <= lilysAge; i+=2)//Odd birthdays
            {
                moneyFromToys += priceOfToy;
            }

            for (int i = 2; i <= lilysAge; i+=2)//Even birthdays
            {
                moneyFromEvenBirthdays += moneyOnEvenBirthdays;
                moneyFromEvenBirthdays -= 1;//Her brother has taken 1 lev every even year
                moneyOnEvenBirthdays += 10.00;
            }
            if ((moneyFromEvenBirthdays+moneyFromToys) >= priceOfWashingMachine)
            {
                Console.WriteLine("Yes! {0:f2}",Math.Abs( (moneyFromEvenBirthdays + moneyFromToys)-priceOfWashingMachine));

            }
            else if ((moneyFromEvenBirthdays+moneyFromToys) < priceOfWashingMachine)
            {
                Console.WriteLine("No! {0:f2}", Math.Abs((moneyFromEvenBirthdays+moneyFromToys)-priceOfWashingMachine));
            }
        }
    }
}
