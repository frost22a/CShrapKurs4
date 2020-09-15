using System;
using System.Collections.Generic;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\ArraysPracticalExample_CSV\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            Queue<City> cities = csvReader.ReadAllCities();
                      
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }


        }
    }
}
