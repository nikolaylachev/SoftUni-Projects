﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {

            //string secondOpCode = Console.ReadLine();
            string opCode = string.Empty;
            while(opCode != "END")
            {
                opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }

                if (opCode != "END")
                {
                    Console.WriteLine(result); 
                }
               // break;
            } 
        }
    }
}