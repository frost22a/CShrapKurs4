using System;

namespace ArraysPracticalExample_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\ArraysPracticalExample_CSV\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            City[] cities = csvReader.ReadFirstNCities(7);

            foreach (var city in cities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
