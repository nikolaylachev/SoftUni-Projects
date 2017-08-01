using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var numberOfPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var percentageOfGoodPictures = int.Parse(Console.ReadLine());
            var timeForUploadingFilteredPic = int.Parse(Console.ReadLine());

            
            
                var goodPictures = (long)Math.Ceiling((numberOfPictures * (percentageOfGoodPictures / 100d)));
                var timeForAllPictures = (long)numberOfPictures * filterTime;
                var timeForUploadingFilteredPictures = (long)goodPictures * timeForUploadingFilteredPic;
                var totalTime = timeForAllPictures + timeForUploadingFilteredPictures;
                
                var days = totalTime / 86400;
                var hours = (totalTime / 3600);
                var minutes = ((totalTime - (hours * 3600)) / 60);
                var seconds = ((totalTime - (hours * 3600)) % 60);
                Console.WriteLine($"{days:d1}:{hours:d2}:{minutes:d2}:{seconds:d2}"); 
            }
    }
}
