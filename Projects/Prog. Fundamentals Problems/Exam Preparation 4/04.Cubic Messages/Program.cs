﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]*)$";

            var messageRegex = new Regex(pattern);

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Over!")
                {
                    break;
                }

                var messageMatch = Regex.Match(line,pattern);

                if (!messageMatch.Success)
                {
                    continue;
                }

                var leftPart = messageMatch.Groups["leftPart"].Value;
                var message = messageMatch.Groups["message"].Value;
                var rightPart = messageMatch.Groups["rightPart"].Value;

                var messageLength = int.Parse(Console.ReadLine());

                if (messageLength != message.Length)
                {
                    continue;
                }

                var verificationCode = new string((leftPart + rightPart)
                    .Where(char.IsDigit)
                    .Select(a => int.Parse(a.ToString()))
                    .Select(index => (index >=0 && index < message.Length) ? message[index] : ' ')
                    .ToArray());

                Console.WriteLine($"{message} == {verificationCode}");
            }


           
        }
    }
}
