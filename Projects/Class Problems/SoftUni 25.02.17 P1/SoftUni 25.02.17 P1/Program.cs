using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_25._02._17_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRounds = int.Parse(Console.ReadLine());
            string[] rounds = new string[numberOfRounds];
            int sumOfMitko = 0;
            int sumOfVladko = 0;
            int difference = 0;

            for (int i = 0; i < rounds.Length; i++)
            {
                rounds[i] = Console.ReadLine();
            }

            for (int i = 0; i < rounds.Length; i++)
            {
                if (rounds[i].Length%2==0)
                {

                    for (int j = 0; j < rounds[i].Length/2; j++)//12 34
                    {
                        sumOfMitko += (int)char.GetNumericValue(rounds[i][j]);
                    }

                    for (int j = (rounds[i].Length/2); j < rounds[i].Length; j++)//34
                    {
                        sumOfVladko += (int)char.GetNumericValue(rounds[i][j]);
                    }
                    difference = Math.Abs(sumOfMitko - sumOfVladko);
                }

                else if (rounds[i].Length%2==1)
                {
                    for (int j = 0;  j < (rounds[i].Length/2)+1;  j++)
                    {
                        sumOfMitko += (int)char.GetNumericValue(rounds[i][j]);
                    }

                    for (int j = rounds[i].Length/2; j < rounds[i].Length; j++)
                    {
                        sumOfVladko += (int)char.GetNumericValue(rounds[i][j]);
                    }
                    difference = Math.Abs(sumOfMitko - sumOfVladko);
                }
            }
            if (sumOfMitko > sumOfVladko)
            {
                Console.WriteLine("M {0}",difference);
            }
            else if (sumOfMitko<sumOfVladko)
            {
                Console.WriteLine("V {0}",difference);
            }
            else if (sumOfMitko == sumOfVladko)
            {
                Console.WriteLine("No {0}",(sumOfMitko+sumOfVladko));
            }
            //Console.WriteLine("{0} {1} {2}",sumOfMitko,sumOfVladko,difference);

        }
    }
}
