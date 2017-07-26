using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers_24._04._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1, secondNumber = 1, thirdNumber = 1, fourthNumber = 1;
            int n = int.Parse(Console.ReadLine());
            for (firstNumber=1; firstNumber <=9; firstNumber++)
            {
                for (secondNumber = 1; secondNumber <=9; secondNumber++)
                {
                    for (thirdNumber = 1; thirdNumber <= 9; thirdNumber++)
                    {
                        for (fourthNumber = 1; fourthNumber <=9 ;fourthNumber++)
                        {
                            if (n%firstNumber==0 && n%secondNumber==0 && n%thirdNumber==0 && n%fourthNumber==0)
                            {
                                Console.Write("{0}{1}{2}{3} ",firstNumber,secondNumber,thirdNumber,fourthNumber);
                            }
                        }
                    }
                }
            }
        }
    }
}
