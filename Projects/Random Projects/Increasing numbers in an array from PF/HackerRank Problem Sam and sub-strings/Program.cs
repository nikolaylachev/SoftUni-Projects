using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Sam_and_sub_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 -> 1 || 1 -> 1
            //12 -> 1,2,12 || 1 + 2 = 3 || 2 -> 3
            //123 -> 1,2,3,12,23,123 || 3 + 3 = 6 || 3 -> 6
            //1234 -> 1,2,3,4,12,23,34,123,234,1234 || 6 + 4 = 10 || 4 -> 10
            //12345 -> 1,2,3,4,5,12,23,34,45,123,234,345,1234,2345,12345 || 10 + 5 =15 || 5 -> 15
            //123456 -> 1,2,3,4,5,6,12,23,34,45,56,123,234,345,456,1234,2345,3456,12345,23456,123456 || 15 + 6 = 21 || 6 -> 21
            string value = "1234";
            // Avoid full length.
            for (int length = 1; length < value.Length; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
