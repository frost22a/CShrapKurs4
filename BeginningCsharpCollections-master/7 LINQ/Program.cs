using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\2 ArrayPracticalExample\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            List<City> citys = csvReader.ReadAllCiyts();

            var filteredCitys = citys.Where(c => !c.CityName.Contains("Test")).Take(10);

            var filteredCitys2 = (from city in citys
                                  where !city.CityName.Contains("Test")
                                  select city).Take(10);

            foreach (var city in filteredCitys2)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
        }
    }
}
