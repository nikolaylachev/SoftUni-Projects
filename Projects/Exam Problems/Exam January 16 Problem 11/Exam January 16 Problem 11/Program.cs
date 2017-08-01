using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a-b)>=3)
            {
                for (int firstNumber = a; firstNumber <= b; firstNumber++)
                {
                    for (int secondNumber = firstNumber + 1; secondNumber <= b; secondNumber++)
                    {
                        for (int thirdNumber = secondNumber + 1; thirdNumber <= b; thirdNumber++)
                        {
                            for (int fourthNumber = thirdNumber + 1; fourthNumber <= b; fourthNumber++)
                            {
                                if (a <= firstNumber && firstNumber < secondNumber && secondNumber < thirdNumber && thirdNumber < fourthNumber && fourthNumber <= b)
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
                                }

                            }
                        }
                    }
                } 
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
