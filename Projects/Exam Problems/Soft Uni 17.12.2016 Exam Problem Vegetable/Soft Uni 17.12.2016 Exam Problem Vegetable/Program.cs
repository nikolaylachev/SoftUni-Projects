using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Uni_17._12._2016_Exam_Problem_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfVegetables = double.Parse(Console.ReadLine());
            double priceOfFruits = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitWeight = int.Parse(Console.ReadLine());
            double totalPriceInEuro = ((priceOfVegetables * vegetablesWeight) + (priceOfFruits * fruitWeight))/1.94;
            Console.WriteLine(totalPriceInEuro);
        }
    }
}
