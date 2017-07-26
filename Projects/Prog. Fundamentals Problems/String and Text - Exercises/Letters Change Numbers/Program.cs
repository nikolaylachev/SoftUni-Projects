using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();

            alphabet['a'] = 1; alphabet['A'] = 1;
            alphabet['b'] = 2; alphabet['B'] = 2;
            alphabet['c'] = 3; alphabet['C'] = 3;
            alphabet['d'] = 4; alphabet['D'] = 4;
            alphabet['e'] = 5; alphabet['E'] = 5;
            alphabet['f'] = 6; alphabet['F'] = 6;
            alphabet['g'] = 7; alphabet['G'] = 7;
            alphabet['h'] = 8; alphabet['H'] = 8;
            alphabet['i'] = 9; alphabet['I'] = 9;
            alphabet['j'] = 10; alphabet['J'] = 10;
            alphabet['k'] = 11; alphabet['K'] = 11;
            alphabet['l'] = 12; alphabet['L'] = 12;
            alphabet['m'] = 13; alphabet['M'] = 13;
            alphabet['n'] = 14; alphabet['N'] = 14;
            alphabet['o'] = 15; alphabet['O'] = 15;
            alphabet['p'] = 16; alphabet['P'] = 16;
            alphabet['q'] = 17; alphabet['Q'] = 17;
            alphabet['r'] = 18; alphabet['R'] = 18;
            alphabet['s'] = 19; alphabet['S'] = 19;
            alphabet['t'] = 20; alphabet['T'] = 20;
            alphabet['u'] = 21; alphabet['U'] = 21;
            alphabet['v'] = 22; alphabet['V'] = 22;
            alphabet['w'] = 23; alphabet['W'] = 23;
            alphabet['x'] = 24; alphabet['X'] = 24;
            alphabet['y'] = 25; alphabet['Y'] = 25;
            alphabet['z'] = 26; alphabet['Z'] = 26;

            List<string> input = Console.ReadLine().Split(' ', '\t').Where(i => i !="").ToList();
            input.RemoveAll(str => string.IsNullOrEmpty(str));//Removes all empty entries in the input list

            double sumOfElement = 0.0D;
            double totalSum = 0.0D;

            StringBuilder numberFromString = new StringBuilder("");// new List<String>();
            List<StringBuilder> numbersFromString = new List<StringBuilder>();
            StringBuilder letterFromString = new StringBuilder("");
            List<StringBuilder> lettersFromString = new List<StringBuilder>();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] >= '0' && input[i][j] <= '9')
                    {
                        numberFromString.Append(input[i][j]);
                    }
                    else if (input[i][j] >= 'A' && input[i][j] <= 'Z' || input[i][j] >= 'a' && input[i][j] <= 'z')
                    {
                        letterFromString.Append(input[i][j]);
                    }
                }
                numbersFromString.Add(numberFromString);
                numberFromString = new StringBuilder("");

                lettersFromString.Add(letterFromString);
                letterFromString = new StringBuilder();
            }

            double numberFromNumbersList = 0.0D;

            for (int numbersFirstIndex = 0, lettersFirstIndex = 0; lettersFirstIndex < lettersFromString.Count; numbersFirstIndex++, lettersFirstIndex++)
            {
                numberFromNumbersList = double.Parse(numbersFromString[numbersFirstIndex].ToString());

                for (int lettersSecondIndex = 0; lettersSecondIndex < lettersFromString[lettersFirstIndex].Length; lettersSecondIndex++)
                {
                    if (alphabet.ContainsKey(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        char.IsLower(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        lettersSecondIndex == 0)
                    {
                        numberFromNumbersList *= alphabet[lettersFromString[lettersFirstIndex][lettersSecondIndex]];
                    }

                    else if (alphabet.ContainsKey(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        char.IsUpper(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        lettersSecondIndex == 0)
                    {
                        numberFromNumbersList /= alphabet[lettersFromString[lettersFirstIndex][lettersSecondIndex]];
                    }

                    if (alphabet.ContainsKey(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        char.IsLower(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        lettersSecondIndex == 1)
                    {
                        numberFromNumbersList += alphabet[lettersFromString[lettersFirstIndex][lettersSecondIndex]];
                    }

                    else if (alphabet.ContainsKey(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        char.IsUpper(lettersFromString[lettersFirstIndex][lettersSecondIndex]) &&
                        lettersSecondIndex == 1)
                    {
                        numberFromNumbersList -= alphabet[lettersFromString[lettersFirstIndex][lettersSecondIndex]];
                    }

                }
                sumOfElement += numberFromNumbersList;
                totalSum += sumOfElement;

                sumOfElement = 0.0D;
                numberFromNumbersList = 0.0D;
            }
            //BigDecimal
            Console.WriteLine($"{totalSum:f2}");
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(decimal.MaxValue);
            
            //Console.WriteLine(decimal.MaxValue > 55834574822);
        }
    }
}
