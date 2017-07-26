using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Division_wout_reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double divideByTwoCounter = 0, divideByThreeCounter = 0, divideByFourCounter=0 ;
            double TwosInPercent, ThreesInPercent, FoursInPercent;
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int [size];//Declaring an array with n elements.

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());//Entering values in the array.
            }

            for (int i = 0; i < numbers.Length; i++)//i < size is also valid.
            {
                if (numbers[i]%2==0)
                {
                    divideByTwoCounter++; 
                }
                if (numbers[i]%3==0)
                {
                    divideByThreeCounter++;
                }
                if (numbers[i]%4==0)
                {
                    divideByFourCounter++;
                }
            }

            TwosInPercent = (divideByTwoCounter / size)*100;//n*100
            ThreesInPercent = (divideByThreeCounter / size)*100;//n*100
            FoursInPercent = (divideByFourCounter / size)*100;//n*100
            Console.WriteLine("{0:f2}%",TwosInPercent);
            Console.WriteLine("{0:f2}%",ThreesInPercent);
            Console.WriteLine("{0:f2}%",FoursInPercent);
        }
    }
}
