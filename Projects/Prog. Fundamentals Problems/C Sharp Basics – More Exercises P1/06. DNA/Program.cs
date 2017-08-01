using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            //int valueOfFirst = 0, valueOfSecond = 0, valueOfThird = 0;

            for (int first = 1; first <= 4; first++)
            {
                for (int second = 1; second <= 4; second++)
                {
                    for (int third = 1; third <= 4; third++)
                    {
                        counter++;
                        if (first+second+third>=number)
                        {
                            Console.Write("O" + ("" + first + second + third).Replace('1','A').Replace('2','C').Replace('3','G').Replace('4','T') + "O "); 
                        }
                        else
                        {
                            Console.Write("X" + ("" + first + second + third).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (counter %4 == 0)
                        {
                            Console.WriteLine();
                        }
                       
                    }
                        
                }
            }

            }
        }
    /*
    counter++;
                        if ((first == 'A' || first == 'C' || first == 'G' || first == 'T')
                            && (second == 'A' || second == 'C' || second == 'G' || second == 'T')
                            && (third == 'A' || third == 'C' || third == 'G' || third == 'T'))
                        {
                            Console.Write($"X{first}{second}{third}X");
                            if (counter % 4 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
*/
    /*
     *  counter++;
                            //First A
                            if (first=='A')
                            {
                                valueOfFirst = 1;
                                if (second=='A')
                                {
                                    valueOfSecond = 1;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst+valueOfSecond+valueOfThird >= number)
                                        {
                                            if (counter%4==0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  "); 
                                            }
                                        }
                                        else if (valueOfFirst+valueOfSecond+valueOfThird < number)
                                        {
                                            if (counter%4==0)
                                            {
                                                Console.Write($"X{first}{second}{third}X "); 
                                            }
                                        }
                                    }
                                    if (third=='C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third=='G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third=='T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second=='C')
                                {
                                    valueOfSecond = 2;
                                    if (third == 'A')
                                    {
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second=='G')
                                {
                                    valueOfSecond = 3;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second=='T')
                                {
                                    valueOfSecond = 4;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                            }
                            //First C
                            if (first=='C')
                            {
                                valueOfFirst = 2;
                                if (second == 'A')
                                {
                                    valueOfSecond = 1;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'C')
                                {
                                    valueOfSecond = 2;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'G')
                                {
                                    valueOfSecond = 3;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'T')
                                {
                                    valueOfSecond = 4;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                            }
                            //First G
                            if (first=='G')
                            {
                                valueOfFirst = 3;
                                if (second == 'A')
                                {
                                    valueOfSecond = 1;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'C')
                                {
                                    valueOfSecond = 2;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'G')
                                {
                                    valueOfSecond = 3;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'T')
                                {
                                    valueOfSecond = 4;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                            }
                            //First T
                            if (first=='T')
                            {
                                valueOfFirst = 4;
                                if (second == 'A')
                                {
                                    valueOfSecond = 1;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'C')
                                {
                                    valueOfSecond = 2;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'G')
                                {
                                    valueOfSecond = 3;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        valueOfThird = 3;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                                if (second == 'T')
                                {
                                    valueOfSecond = 4;
                                    if (third == 'A')
                                    {
                                        valueOfThird = 1;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'C')
                                    {
                                        valueOfThird = 2;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'G')
                                    {
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                    if (third == 'T')
                                    {
                                        valueOfThird = 4;
                                        if (valueOfFirst + valueOfSecond + valueOfThird >= number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"O{first}{second}{third}O  ");
                                            }
                                        }
                                        else if (valueOfFirst + valueOfSecond + valueOfThird < number)
                                        {
                                            if (counter % 4 == 0)
                                            {
                                                Console.Write($"X{first}{second}{third}X ");
                                            }
                                        }
                                    }
                                }
                            }
     */
}

