﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // Console.WriteLine(string.Join(" ",arr));

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            short dayOfWeek = short.Parse(Console.ReadLine());
            if (dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                Console.WriteLine(daysOfWeek[dayOfWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
