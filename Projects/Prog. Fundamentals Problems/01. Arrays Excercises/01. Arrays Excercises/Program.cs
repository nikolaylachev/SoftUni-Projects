using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrays_Excercises
{
    class Program
    {
        // int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        static string [] ReverseFirstStringArray(string[] str)
        {
            string[] reversedString = new string[str.Length];
            for (int i = 0,j = str.Length-1 ; i < str.Length; i++,j--)
            {
                reversedString[i] = str[j];
            }
            return reversedString;
        }
        
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();
            string[] str2 = Console.ReadLine().Split(' ');
            int min = Math.Min(str.Length, str2.Length);
            int max = Math.Max(str.Length, str2.Length);
            string [] str3 =  new string [min];
            int leftCounter = 0;
            int rightCounter = 0;
             for (int i = 0; i < min ; i++)
             {
                if (str[i] == str2[i])
                {
                    leftCounter++;
                    str3[i] = str[i];
                }
             }
            //Console.WriteLine($"Left counter = {leftCounter}");
            if (leftCounter > 0)
            {
                str = ReverseFirstStringArray(str);
                str2 = ReverseFirstStringArray(str2);
                for (int i = 0; i < min-leftCounter; i++)
                {
                    if (str[i] == str2[i])
                    {
                        rightCounter++;
                    }
                } 
            }
            else if(leftCounter <= 0)
            {
                str = ReverseFirstStringArray(str);
                str2 = ReverseFirstStringArray(str2);
                for (int i = 0; i < min; i++)
                {
                    if (str[i] == str2[i])
                    {
                        rightCounter++;
                    }
                }
            }

            if (leftCounter > 0 && rightCounter==0)
            {
                Console.WriteLine(leftCounter);
            }
            else if(leftCounter == 0 && rightCounter > 0)
            {
                Console.WriteLine(rightCounter);
            }
            else if (leftCounter == 0 && rightCounter ==0)
            {
                Console.WriteLine("0");
            }
            //Console.WriteLine($"Rigt counter = {rightCounter}");
            //Console.WriteLine();
            //Console.WriteLine("First array:");
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.Write($"{str[i]} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Second array:");
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    Console.Write($"{str2[i]} ");
            //}
            //Console.WriteLine();
        }
    }
}
