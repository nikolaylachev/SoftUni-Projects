using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Fish_Market_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfSkomria = double.Parse(Console.ReadLine());
            double priceOfCaca = double.Parse(Console.ReadLine());
            double PalamudInKg = double.Parse(Console.ReadLine());
            double SaphridInKg = double.Parse(Console.ReadLine());
            int MidiInKg = int.Parse(Console.ReadLine());

            double priceOfPalamud = priceOfSkomria + (priceOfSkomria * 0.6);
            double sumPalamud = PalamudInKg * priceOfPalamud;

            double priceOfSaphrid = priceOfCaca + (priceOfCaca * 0.8);
            double sumSaphrid = priceOfSaphrid * SaphridInKg;

            double priceOfMidi = MidiInKg * 7.50;
            double total = sumPalamud + sumSaphrid + priceOfMidi;
            Console.WriteLine("{0:f2}",Math.Round(total,2));
        }
    }
}
