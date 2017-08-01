using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
       public class File
        {
            public string Root { get; set; }
            public string FullFileName  { get; set; }
            public string Extension { get; set; }
            public string Size { get; set; }
        }

        static void Main(string[] args)
        {
            string inputLine = "";//@"Windows\Temp\win.exe;5423";
            string pattern = @"(\w+)\\{1}(\w+[\\\w]*)+\\(\w+\.(\w+)){1}\;(\d+){1}";//(\w+)\\{1}(\w+[\\\w]*)+\\(\w+\.(\w+)){1}\;(\d+){1}

            List<File> filesList = new List<File>();
            //Dictionary<string, File> filesDict = new Dictionary<string, File>();//<Full file name , File props>


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine();
                Match match = Regex.Match(inputLine, pattern);
                if (match.Success)
                {
                    File file = new File()
                    {
                        Root = match.Groups[1].Value,
                        FullFileName = match.Groups[3].Value,
                        Extension = match.Groups[4].Value,
                        Size = match.Groups[5].Value
                    };

                    if (filesList.Count == 0)
                    {
                        filesList.Add(file); 
                    }
                    else if (filesList.Count > 0)
                    {
                        filesList.Add(file);
                    }

                    /*if (!filesDict.ContainsKey(match.Groups[3].Value))
                    {
                        filesDict.Add(match.Groups[3].Value, file); 
                    }
                    else if (filesDict.ContainsKey(match.Groups[3].Value) && !filesDict.ContainsValue(file))
                    {
                        //filesDict.Add(match.Groups[3].Value, file);
                        filesDict[match.Groups[3].Value] = file;
                    }*/
                }
            }

            if (filesList.Contains())
            {

            }
            for (int i = 0; i < filesList.Count; i++)
            {

            }
            foreach (var file in filesList)
            {
                Console.WriteLine($"Root: {file.Root}, File name: {file.FullFileName}");
                //Console.WriteLine(file.Root);
            }
            /*foreach (var file in filesDict)
            {
                Console.WriteLine($"File name: {file.Key}");

                Console.WriteLine($"Root: {file.Value.Root}, File name: {file.Value.FullFileName}, Size: {file.Value.Size}");
                Console.WriteLine();
            }*/

            string command = Console.ReadLine();


        }
    }
}
