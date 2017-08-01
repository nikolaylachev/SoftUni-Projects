using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOFRounds = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOFRounds];

            double result = 0.00D;
            double firstCounter = 0.0, secondCounter = 0.0, thirdCounter = 0.0, fourthCounter = 0.0, fifthCounter = 0.0, sixthCounter = 0.0; ;

            for (int i = 0; i < numberOFRounds; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOFRounds; i++)
            {
                if (numbers[i]>=0 && numbers[i]<=9)
                {
                    result += (numbers[i] * 0.2);
                    firstCounter++;
                }
                if (numbers[i] >= 10 && numbers[i] <= 19)
                {
                    result += (numbers[i] * 0.3);
                    secondCounter++;
                }
                if (numbers[i] >= 20 && numbers[i] <= 29)
                {
                    result += (numbers[i] * 0.4);
                    thirdCounter++;
                }
                if (numbers[i] >= 30 && numbers[i] <= 39)
                {
                    result += 50;
                    fourthCounter++;
                }
                if (numbers[i] >= 40 && numbers[i] <= 50)
                {
                    result += 100;
                    fifthCounter++;
                }
                if (numbers[i] < 0 || numbers[i] > 50)//Invalid number
                {
                    result /= 2;
                    sixthCounter++;
                }
            }
            Console.WriteLine("{0:f2}",result);
            double firstProcent = firstCounter / numberOFRounds * 100.00;
            double secondProcent = secondCounter / numberOFRounds * 100.00;
            double thirdProcent = thirdCounter / numberOFRounds * 100.00; 
            double fourthProcent= fourthCounter/numberOFRounds * 100.00;
            double fifthProcent = fifthCounter / numberOFRounds * 100.00;
            double sixthProcent = sixthCounter / numberOFRounds * 100.00;

            Console.WriteLine("From 0 to 9: {0:f2}%",firstProcent);
            Console.WriteLine("From 10 to 19: {0:f2}%", secondProcent);
            Console.WriteLine("From 20 to 29: {0:f2}%", thirdProcent);
            Console.WriteLine("From 30 to 39: {0:f2}%", fourthProcent);
            Console.WriteLine("From 40 to 50: {0:f2}%", fifthProcent);
            Console.WriteLine("Invalid numbers: {0:f2}%", sixthProcent);
        }
    }
}
