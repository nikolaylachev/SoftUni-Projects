using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Enter password below:");
            string password = "";
            string text = "";
            
            do
            {
                password = Console.ReadLine();

                if (password == "pesho")
                {
                    Console.WriteLine("Enter text below:");
                    string file = File.ReadAllText("Diary.txt");//Reads the file.

                    DateTime now = DateTime.Now;//Gets current date and time.
                    string date = now.ToString() + Environment.NewLine;//Gets the current date and time and adds new line!
                    string separator = "-------------------" + Environment.NewLine;
                    text = Console.ReadLine() + Environment.NewLine;//Reads the message and adds new line in the file!

                    File.AppendAllText("Diary.txt", date);//Adds the date to the file.
                    File.AppendAllText("Diary.txt", separator);//Adds separator.
                    File.AppendAllText("Diary.txt", text);//Adds the text to the file.
                }

                else if (password != "pesho")
                {
                    Console.WriteLine("Password is not correct. Try again.");
                    //Console.WriteLine();
                } 
            } while (password != "pesho");

        }
    }
}
