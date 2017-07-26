using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Equal_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First of all enter the rows of the wanted picture.");
            Console.WriteLine("Then enter each row of the wanted picture and the other picture or just copy and paste them.");
            Console.Write("Enter the rows of the wanted picture: ");
            int RowsOfWantedPicture = int.Parse(Console.ReadLine());
            string[] wantedPicture = new string[RowsOfWantedPicture];
            string[] enteredPicture = new string[RowsOfWantedPicture];

            for (int RowsOfWantedPictureIndex = 0; RowsOfWantedPictureIndex < wantedPicture.Length; RowsOfWantedPictureIndex++)
            {
                //Console.Write("Enter {0} row: ",RowsOfWantedPictureIndex+1);
                wantedPicture[RowsOfWantedPictureIndex] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int rowsOfEnterPicture = 0; rowsOfEnterPicture < enteredPicture.Length; rowsOfEnterPicture++)
            {
                //Console.Write("Enter {0} row: ",rowsOfEnterPicture+1);
                enteredPicture[rowsOfEnterPicture] = Console.ReadLine();
            }

            int equalCounter = 0;

            for (int i = 0; i < wantedPicture.Length; i++)
            {
                if (wantedPicture[i]==enteredPicture[i])
                {
                    equalCounter++;
                }
                
            }
            if (equalCounter==RowsOfWantedPicture)
            {
                Console.WriteLine("The two pictures are equal.");
            }
            else
            {
                Console.WriteLine("The two pictures are not equal.");
            }
        }
    }
}
