using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Magic_Number_26._03._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int first, second, third, fourth, fifth, sixth;
            for (first = 1; first <=9; first++)
            {
                for ( second = 1; second <= 9; second++)
                {
                    for (third = 1; third <= 9; third++)
                    {
                        for (fourth = 1; fourth <= 9; fourth++)
                        {
                            for (fifth = 1; fifth <= 9; fifth++)
                            {
                                for (sixth = 1; sixth <= 9; sixth++)
                                {

                                    if ((first*second*third*fourth*fifth*sixth)==magicNumber)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ",first,second,third,fourth,fifth,sixth);
                                    }
                                }//End of 1st for
                            }//End of 2nd for
                        } //End of 3th for
                    }//End of 4th for
                }//End of 5th for
            }//End of 6th for
        }
    }
}
