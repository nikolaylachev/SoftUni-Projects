﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_BASIC_SYNTAX___EXERCISES_23._05._17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first:D4} {second:D4} {third:D4} {fourth:D4}");
        }
    }
}