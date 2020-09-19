using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {


            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\CollectionsOfCollections\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            Dictionary<string, List<City>> cities = new Dictionary<string, List<City>>();

            cities = csvReader.ReadAllCities();

            //var city = cities["Polska"].ElementAt(0);
            //Console.WriteLine(cities["Polska"].ElementAt(2).CityName);
            //Console.WriteLine(city.CityName);


            //foreach (KeyValuePair<string, List<City>> pair in cities)
            //{
            //    Console.WriteLine(pair);
            //}

            //Console.WriteLine();
            //Console.WriteLine("cities.Keys");

            foreach (string countryName in cities.Keys) // string można zastąpić przez var
            {
                Console.WriteLine(countryName);
            }

            //Console.WriteLine();
            //Console.WriteLine("cities.Values");

            //foreach (List<City> List in cities.Values) // List<City> można zastąpić przez var
            //{
            //    Console.WriteLine(List);
            //}

            

            while (true)
            {
                
                Console.WriteLine("Choose a counrty (leave blank to quit):");
                var choosenCountry = Console.ReadLine();

                if (choosenCountry == "")
                {
                    break;
                }
                
                if (cities.ContainsKey(choosenCountry))
                {
                    foreach (City city in cities[choosenCountry])
                        Console.WriteLine($"{city.TotalPopulation: ### ### ###} : {city.CityName}");
                }
                else
                    Console.WriteLine("There is no such a counrty on the list");
            }

            

        }
    }
}
