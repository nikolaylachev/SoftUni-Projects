using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Prog_Funds_Exam_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePowerN = long.Parse(Console.ReadLine());//N
            var distanceBetweenPokeTargetsM = long.Parse(Console.ReadLine());//M
            var exhaustionFactorY = long.Parse(Console.ReadLine());//Y

            decimal originalValueOfN = pokePowerN;
            long count = 0L;

            while (true)
            {

                if (pokePowerN >= distanceBetweenPokeTargetsM)
                {
                    pokePowerN -= distanceBetweenPokeTargetsM;

                    if (pokePowerN / originalValueOfN * 100 == 50.00M)
                    {
                        try
                        {
                            pokePowerN /= exhaustionFactorY;
                        }
                        catch (DivideByZeroException)
                        {
                            count++;
                            break;
                        }
                    }

                    else
                    {

                    }

                    count++;

                    if (pokePowerN == 0)
                    {
                        break;
                    }
                }

                if (pokePowerN < distanceBetweenPokeTargetsM)
                {
                    break;
                }

            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(count);
        }
    }
}