using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl+K+S - Позволява да обградим маркиран код с нещо по наш избор.
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n ; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(Math.Pow(2, i)); 
                }
            }
        }
    }
}
