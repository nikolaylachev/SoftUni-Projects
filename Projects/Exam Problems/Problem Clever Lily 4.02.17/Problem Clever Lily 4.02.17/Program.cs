using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Clever_Lily_4._02._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            double moneyFromBirthdays = 0.0D;
            double sumOfMoney = 0.0D;
            double sumOfToys = 0.0D,totalSum=0.0D;
            int oddCounter = 0,evenCounter=0;
            double brotherMoney=0.0D;

            for (int birthday = 1; birthday <= lilysAge; birthday++)
            {
                if (birthday%2==0)
                {
                    ++evenCounter;
                    ++brotherMoney;
                    moneyFromBirthdays += 10;
                    sumOfMoney += moneyFromBirthdays;
                    /*++evenCounter;
                    ++brotherMoney;*/
                }
                else if (birthday%2==1)
                {
                    ++oddCounter;
                }
            }
            sumOfToys = oddCounter * priceOfToy;

           totalSum=(sumOfMoney+sumOfToys)-brotherMoney;

            if (totalSum>washingMashinePrice)
            {
                double answer = totalSum - washingMashinePrice;
                Console.WriteLine("Yes! {0:f2}",answer);
            }
            if(totalSum<washingMashinePrice)
            {
                double answer = washingMashinePrice - totalSum;
                Console.WriteLine("No! {0:f2}",answer);
            }
            Console.WriteLine("EvenCounter={0} OddCounter={1} SumOfMoney={2} SumOfToys={3} BrothersMoney={4}", evenCounter,oddCounter,sumOfMoney,sumOfToys, brotherMoney);
        }
    }
}
