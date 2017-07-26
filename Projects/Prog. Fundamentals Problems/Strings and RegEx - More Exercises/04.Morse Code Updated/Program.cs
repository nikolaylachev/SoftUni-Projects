using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code_Updated
{
    class Program
    {
        static int GetSumOfLetter(string message)
        {
            int sum = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == '0')
                {
                    sum += 3;
                }
                else if (message[i] == '1')
                {
                    sum += 5;
                } 
            }

            for (int i = 0; i < message.Length; i++)
            {
                if (i == 0)//First element.
                {
                    if (message[i] == message[i+1])
                    {
                        sum++;
                    }
                    else if (message[i] != message[i+1])
                    {
                        sum += 0;
                    }
                }
                else if (i > 0 && i < message.Length-1)// Elements between the first and the last.
                {
                    if (message[i] == message[i+1])
                    {
                        sum++;
                    }
                    else if (message[i] != message[i+1])
                    {
                        if (message[i] == message[i-1])
                        {
                            sum++;
                        }
                    }
                }
                else if (i == message.Length-1)//Last element.
                {
                    if (message[i] == message[i-1])
                    {
                        sum++;
                    }
                    else if (message[i] != message[i-1])
                    {
                        sum += 0;
                    }
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<char> message = new List<char>(input.Count);

            //Console.WriteLine(GetSumOfLetter(input[0]));
            for (int i = 0; i < input.Count; i++)
            {
                message.Add((char)GetSumOfLetter(input[i]));
            }

            foreach (var letter in message)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
