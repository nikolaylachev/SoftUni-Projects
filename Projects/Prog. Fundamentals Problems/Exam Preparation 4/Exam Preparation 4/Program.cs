using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashAmount = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            var priceOfBananasForSingleUnit = decimal.Parse(Console.ReadLine());
            var priceOfEggsForSingleUnit = decimal.Parse(Console.ReadLine());
            var priceOfBerriesForKilo = decimal.Parse(Console.ReadLine());

            int sets = 0;
            if (numberOfGuests % 6 == 0)
            {
                sets = numberOfGuests / 6;
            }
            else if (numberOfGuests % 6 != 0)
            {
                sets = (numberOfGuests / 6) + 1;
            }

            decimal neededProducts = sets * (2M * priceOfBananasForSingleUnit) + sets * (4M * priceOfEggsForSingleUnit) + sets * (0.2M * priceOfBerriesForKilo);

            if (neededProducts <= cashAmount)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProducts:F2}lv.");
            }

            else if (neededProducts > cashAmount)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededProducts - cashAmount):F2}lv more.");
            }

            decimal d = 5M;
            int i = 5;
            dynamic result = d * i;
            Console.WriteLine(result);
            //result = "result";
            Console.WriteLine(result);

        }
    }
}
