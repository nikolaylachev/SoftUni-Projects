using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            List<int> ladyBugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<long> ladyBugPlayfield = new List<long>(sizeOfField);

            bool areAllIndexesInTheRange = ladyBugIndexes.TrueForAll(x => x >= 0 && x < sizeOfField);

            var allIndexesInTheRange = ladyBugIndexes.Where(x => x >= 0 && x < sizeOfField).ToList();

            //if (areAllIndexesInTheRange == true)
            //{


            for (int i = 0; i < sizeOfField; i++)
            {
                ladyBugPlayfield.Insert(i, 0);
                //ladyBugPlayfield[i] == 0;
            }

            for (int i = 0; i < allIndexesInTheRange.Count/*ladyBugIndexes.Count*/; i++)
            {
                ladyBugPlayfield[allIndexesInTheRange[i]] = 1;
            }

            List<string> command = new List<string>();

            do
            {
                int index = 0;
                command = Console.ReadLine().Split(' ').ToList();

                try
                {
                    index = int.Parse(command[0]);
                }
                catch (Exception)
                {
                    break;
                }


                string direction = command[1];
                int length = int.Parse(command[2]);

                long copyOfCurrentElement = 0;
                if (index >= 0 && index < sizeOfField)
                {
                    copyOfCurrentElement = ladyBugPlayfield[index];
                }

                if (command[0] != "end")
                {
                    if (index >= 0 && index < sizeOfField && ladyBugPlayfield[index] == 1)
                    {
                        if (direction == "right" && index >= 0 && index < sizeOfField)
                        {
                            ladyBugPlayfield[index] = 0;


                            if ((index + length >= 0 && index + length < ladyBugPlayfield.Count) && ladyBugPlayfield[index + length] == 0)
                            {
                                ladyBugPlayfield[index + length] = copyOfCurrentElement;
                            }
                            else if ((index + length >= 0 && index + length < ladyBugPlayfield.Count) && ladyBugPlayfield[index + length] == 1)
                            {
                                int i = 0;
                                while (true)
                                {
                                    if ((index + length + i >= 0 && index + length + i < ladyBugPlayfield.Count)
                                        && ladyBugPlayfield[index + length + i] == 1)
                                    {
                                        i++;
                                    }
                                    else if ((index + length + i >= 0 && index + length + i < ladyBugPlayfield.Count)
                                        && ladyBugPlayfield[index + length + i] == 0)
                                    {
                                        ladyBugPlayfield[index + length + i] = copyOfCurrentElement;
                                        break;
                                    }
                                    else if (index + length + i >= ladyBugPlayfield.Count || index + length + i < 0)
                                    {
                                        break;
                                    }
                                }
                            }

                            else if ((index + length) < 0 || index + length >= ladyBugPlayfield.Count)
                            {
                                continue;
                                //break;
                            }
                        }

                        else if (direction == "left" && index >= 0 && index < sizeOfField)
                        {
                            ladyBugPlayfield[index] = 0;


                            if ((index - length >= 0 && index - length < ladyBugPlayfield.Count) && ladyBugPlayfield[index - length] == 0)
                            {
                                ladyBugPlayfield[index - length] = copyOfCurrentElement;
                            }
                            else if ((index - length >= 0 && index - length < ladyBugPlayfield.Count) && ladyBugPlayfield[index - length] == 1)
                            {
                                int i = 0;
                                while (true)
                                {
                                    if ((index - length + i >= 0 && index - length + i < ladyBugPlayfield.Count) && ladyBugPlayfield[index - length] == 1)
                                    {
                                        i--;
                                    }
                                    else if (index - length + i >= 0 && ladyBugPlayfield[index - length] == 0)
                                    {
                                        ladyBugPlayfield[index - length + i] = copyOfCurrentElement;
                                    }
                                    else if (index - length + i < 0 || index - length + i >= ladyBugPlayfield.Count)
                                    {

                                        break;
                                    }
                                }
                            }
                            else if (index - length < 0 || index - length >= ladyBugPlayfield.Count)
                            {
                                // break;
                            }
                        }
                    }

                    else if (index >= 0 && index < sizeOfField && ladyBugPlayfield[index] == 0)
                    {
                        continue;
                    }
                }

                else if (command[0] == "end")
                {
                    continue;
                }

            } while (true);


            //Console.WriteLine(string.Join(" ", ladyBugPlayfield));
            //}

            Console.WriteLine(string.Join(" ", ladyBugPlayfield)); // this can be wrong!!!!!!!!!!!
        }
    }
}
