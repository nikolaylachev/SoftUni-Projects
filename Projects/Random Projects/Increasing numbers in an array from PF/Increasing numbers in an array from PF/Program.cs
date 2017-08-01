using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_numbers_in_an_array_from_PF
{
    class Program
    {
        static void IncreasingElements(int [] arr)
        {

            int counter = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i-1])
                {
                    counter++;
                }

            }

            if(counter==3)
            {
                Console.WriteLine("Yes"); 
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void NumberOfCapitalLetters(string s1)
        {
            int counter = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i]>='A' && s1[i]<='Z')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static void ArraySymmetry(string [] s)
        {
            int counter = 0;
            string [] s2 = new string [s.Length];
            for (int i = s.Length-1,j=0; i >= 0; i--,j++)
            {
                s2[i] = s[j];
            }

            for (int i = 0,j=0; i < s2.Length; i++,j++)
            {
                if (s[i] == s2[j])
                {
                    counter++;
                }
            }

            if (counter==s.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[4];//For the first function
            string str = "Hello Madafacka!";// For the second function
            string[] str2 = { "hi","ho","ho" };// For the third function

            for (int i = 0; i < 4;  i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            IncreasingElements(arr);
            NumberOfCapitalLetters(str);
            ArraySymmetry(str2);
        }
    }
}
