using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Back_To_The_Past_17._07
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int IvanchosYears = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i%2==0)
                {
                    money -= 12000;
                    IvanchosYears++;
                }
                else if(i%2!=0)
                {
                    money -= 12000 + (50 * IvanchosYears);
                    IvanchosYears++;
                }
            }

            if (money>0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", Math.Abs(money)); 
            }
            else if (money<=0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(money));
            }
        }
    }
}
