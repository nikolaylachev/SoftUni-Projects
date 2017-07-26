using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
    //    public class City
    //    {
    //        public string m_nameOfCity;
    //        public long m_populationOfCity;

    //        public City(string nameOfCity, long populationOfCity)
    //        {
    //            m_nameOfCity = nameOfCity;
    //            m_populationOfCity = populationOfCity;
    //        }
    //    }

    //    public class Country : City
    //    {
    //        public string m_nameOfCountry;
    //        public string m_nameOfCity;
    //        public static long populationOfCity;

    //        public Country(string nameOfCountry, string nameOfCity) : base(nameOfCity,populationOfCity)
    //        {
    //            m_nameOfCountry = nameOfCountry;
    //            m_nameOfCity = nameOfCity;
    //        }
            
    //        public long GetTotalPopulation()
    //        {
    //            long totalPopulation=0L;
    //            totalPopulation += m_populationOfCity;
    //            return totalPopulation;
    //        }
    //    }
       
        /*
           Sofia|Bulgaria|1000
           Teteven|Bulgaria|200
           London|UK|100
           Wells|UK|200
         */
        static void Main(string[] args)
        {
            //List<string>input = new List<string>();
            //Dictionary<long, string> populationOfCountries = new Dictionary<long, string>();//Key: country / Value: population
            //Dictionary<string, string> countries = new Dictionary<string, string>();//Key: city / Value: country
            //Dictionary<string, long> cities = new Dictionary<string, long>();//Key: population / Value: city 
            //do
            //{
            //    input = Console.ReadLine().Split('|').ToList();
            //    Country coun1 = new Country("Bulgaria", "Sofia");
            //    City city1 = new City("Sofia", 1000);
            //    City city2 = new City("Teteven", 200);
            //Console.WriteLine(coun1.GetTotalPopulation());
            //    cities[input[0]] = long.Parse(input[2]);//Convert.ToInt64(input[2]);
            //    countries[input[0]] = input[1];
            //    populationOfCountries[long.Parse(input[2])] = (input[1]);
            //    //foreach (var p in populationOfCountries)
            //    //{
            //    //    if (countries.ContainsKey(p.Key))
            //    //    {
                        
            //    //    }
            //    //} 
            //} while (input[0] != "report");
        }
    }
}
