using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Тhea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!! Not my solution. Taken from: https://softuni.bg/trainings/resources/video/15262/video-screen-1-june-2017-vladimir-damyanovski-programming-fundamentals-may-2017
            var picturesCount = int.Parse(Console.ReadLine());
            var singlePicturesFilterTimeSeconds = int.Parse(Console.ReadLine());
            var filterPercentage = int.Parse(Console.ReadLine());
            var singlePicturesUploadTimeSeconds = int.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)picturesCount * singlePicturesFilterTimeSeconds;
            var picturesToUploadCount = (long)Math.Ceiling(picturesCount * (filterPercentage / 100d));
            var uploadTimeSeconds = picturesToUploadCount * singlePicturesUploadTimeSeconds;

            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;
            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);
            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
