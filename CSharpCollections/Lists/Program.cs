using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> months = new List<string>();

            List<int> ints = new List<int>();

            List<char> chars = new List<char>();

            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");

            //II wersja:

            List<string> months2 = new List<string>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
                "December"
            };

            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\ArraysPracticalExample_CSV\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            List<City> cities = csvReader.ReadAllCities();

            City cityTest = new City("Test","TEST", "Polska", 3000000, 1600000, 1400000 );

            int index = cities.FindIndex(city => city.TotalPopulation < 3000000);
            cities.Insert(index, cityTest);

            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }

            Console.WriteLine($"{cities.Count} Cities");

            cities.RemoveAt(index);
            // lub
            // cities.Remove(cityTest);
            
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }

            Console.WriteLine($"{cities.Count} Cities");

        }
    }
}
