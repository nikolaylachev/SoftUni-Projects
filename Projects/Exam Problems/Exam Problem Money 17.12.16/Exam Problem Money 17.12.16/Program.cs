using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_Money_17._12._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBitCoins = int.Parse(Console.ReadLine());
            double numberOFYons = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double sumInLeva = ((numberOfBitCoins * 1168) + ((numberOFYons * 0.15d) * 1.76d));
            double sumInEuro = (sumInLeva / 1.95d);
            double comissionInNumber = (sumInEuro * 0.05d);
            double totalSumInEuro = (sumInEuro - comissionInNumber);
            Console.WriteLine("{0}",comissionInNumber);
            Console.WriteLine(totalSumInEuro);

        }
    }
}
