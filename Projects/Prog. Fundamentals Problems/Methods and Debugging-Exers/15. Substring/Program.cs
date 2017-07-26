using System;

namespace _15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }

                    string matchedString = string.Empty;
                    if (i + (endIndex + 1) < text.Length)
                    {
                        matchedString = text.Substring(i, endIndex + 1);
                        //break;
                    }
                    else
                    {
                        while (i < text.Length)
                        {
                            matchedString += text[i];
                            i++;
                        }
                    }
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }

        }

        ////static int Input()
        //{
        //    int variable = int.Parse(Console.ReadLine());
        //    return variable;
        //}
        //static double InputDouble()
        //{
        //    double variable = double.Parse(Console.ReadLine());
        //    return variable;
        //}

    }
}
