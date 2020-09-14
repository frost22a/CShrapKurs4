using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ćwiczenia i przykłady

            //City slaskie = new City("Slaskie", "SLA", "Polska", 4524091, 2180662, 2343429);
            //City malopolskie = new City("Malopolskie", "MLP", "Polska", 3404863, 1652663, 1752200);

            //Dictionary<string, City> cities = new Dictionary<string, City>();

            //cities.Add("SLA", slaskie);
            //// lepsza wersjaw tym przykładzie
            //cities.Add(malopolskie.CityCode, malopolskie);

            //City selectedCity = cities[slaskie.CityCode];
            //Console.WriteLine(selectedCity.CityName);

            //foreach (var citykeyvalue in cities)
            //{
            //    Console.WriteLine(citykeyvalue.Value.CityName);  // po city wybieramy, czy chcemy klucz, czy watość, czyli czy .Key czy .Value
            //}

            //// II wersja:

            //foreach (var city in cities.Values)
            //{
            //    Console.WriteLine(city.CityName);
            //}

            ////  wyszukiwanie tryGetValue:

            //var searchedCity = cities.TryGetValue("WLK", out City city1);

            //if (searchedCity)
            //    Console.WriteLine(city1.CityName);

            //else
            //    Console.WriteLine("There is no city with this code");

            ////usuwanie:
            //cities.Remove(malopolskie.CityCode);

            //cities[slaskie.CityCode] = malopolskie;

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city.Value.CityName);
            //}

            //bool exists = cities.ContainsKey(slaskie.CityCode);
            //Console.WriteLine(exists);

            #endregion

            #region głowne zadanie

            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\ArraysPracticalExample_CSV\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            Dictionary<string, City> cities = csvReader.ReadAllCities();

            Console.WriteLine("Which city code do you want to look for?? ");

            string userInput = Console.ReadLine();

            bool getCity = cities.TryGetValue(userInput, out City city);

            if (!getCity)
                Console.WriteLine($"There is no city with code: {userInput}");
            else
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");

            foreach (var kod in cities.Keys)
            {
                Console.WriteLine(kod);
            }

            #endregion
        }
    }
}
