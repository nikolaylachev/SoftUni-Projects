﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_Stop_Number_17._07._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//n<=s<=m
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i%2==0 && i%3==0)
                {
                    if (i==s)
                    {
                        break;
                    }
                    
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}