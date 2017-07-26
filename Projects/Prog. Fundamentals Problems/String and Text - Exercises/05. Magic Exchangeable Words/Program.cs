using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static bool CheckForExchangeableWords(List<string> words)
        {
            string firstString = words[0];//"aabbccbb"; bearded
            string secondString = words[1];//"nnooppzz"; heardad

            Dictionary<char, char> charactersDict = new Dictionary<char, char>();
            bool isExchangable = false;
            bool isSecondForNeeded = true;

            if (firstString.Length == secondString.Length)
            {
                for (int i = 0, j = 0; i < Math.Min(firstString.Length, secondString.Length); i++, j++)
                {
                    
                    if (!charactersDict.ContainsKey(firstString[i]) && !charactersDict.ContainsValue(secondString[j]))
                    {
                        charactersDict[firstString[i]] = secondString[j];
                    }
                    else if (!charactersDict.ContainsKey(firstString[i]) && charactersDict.ContainsValue(secondString[j]))
                    {
                        isExchangable = false;
                        isSecondForNeeded = false;
                        break;
                    }
                }

                if (isSecondForNeeded == true)
                {
                    for (int i = 0, j = 0; i < Math.Min(firstString.Length, secondString.Length); i++, j++)
                    {
                        if (charactersDict[firstString[i]] != secondString[j])
                        {
                            isExchangable = false;
                            break;
                        }
                        else if (charactersDict[firstString[i]] == secondString[j])
                        {
                            isExchangable = true;
                        }
                    } 
                }
            }

            else if (firstString.Length != secondString.Length)
            {

                if (firstString.Length < secondString.Length)
                {
                    for (int i = 0, j = 0; i < Math.Min(firstString.Length, secondString.Length); i++, j++)
                    {
                        if (!charactersDict.ContainsKey(firstString[i]) && !charactersDict.ContainsValue(secondString[j]))
                        {
                            charactersDict[firstString[i]] = secondString[j];
                        }
                        else if (!charactersDict.ContainsKey(firstString[i]) && charactersDict.ContainsValue(secondString[j]))
                        {
                            isExchangable = false;
                            isSecondForNeeded = false;
                            break;
                        }
                    }

                    if (isSecondForNeeded == true)
                    {
                        for (int i = firstString.Length; i < secondString.Length; i++)
                        {
                            if (charactersDict.ContainsValue(secondString[i]))
                            {
                                isExchangable = true;
                            }
                            else
                            {
                                isExchangable = false;
                                break;
                            }

                        } 
                    }
                }

                else if (secondString.Length < firstString.Length)
                {

                    for (int i = 0, j = 0; i < Math.Min(firstString.Length, secondString.Length); i++, j++)
                    {
                        if (!charactersDict.ContainsKey(secondString[i]) && !charactersDict.ContainsValue(firstString[j]))
                        {
                            charactersDict[secondString[i]] = firstString[j];  
                        }
                        else if (!charactersDict.ContainsKey(secondString[i]) && charactersDict.ContainsValue(firstString[j]))
                        {
                            isExchangable = false;
                            isSecondForNeeded = false;
                            break;
                        }
                    }


                    if (isSecondForNeeded == true)
                    {
                        for (int i = secondString.Length; i < firstString.Length; i++)
                        {
                            if (charactersDict.ContainsValue(firstString[i]))
                            {
                                isExchangable = true;
                            }
                            else
                            {
                                isExchangable = false;
                                break;
                            }
                        } 
                    }

                }
            }

            return isExchangable;
        }

        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            bool areExchangables = CheckForExchangeableWords(input);
    
           if (areExchangables == true)
            {
                Console.WriteLine("true"); 
            }
            else
            {
                Console.WriteLine("false");
            }
            
        }

    }
}
