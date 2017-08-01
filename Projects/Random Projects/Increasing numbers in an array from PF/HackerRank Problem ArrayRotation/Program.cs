using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLVED!!! Using list
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int d = Convert.ToInt32(input[1]);
            string[] input2 = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();

            for (int i = 0; i < input2.Length; i++)
            {
                list.Add( Convert.ToInt32(input2[i]));//ADDING ELEMENTS TO THE LIST!!!
                
            }

            int firstElement; 
            for (int i = 1; i <= d; i++)
            {
                firstElement = list[0];
                list.Remove(list[0]);
                list.Add(firstElement);
                
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", list[i]);
            }

        }
    }
}
