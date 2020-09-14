using System;
using System.Collections.Generic;

namespace _4_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\2 ArrayPracticalExample\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            Dictionary<string, City> citys = csvReader.ReadAllCiyts();

            Console.WriteLine("Which city code do you want to search for? ");
            string userInput = Console.ReadLine();

            bool getCity = citys.TryGetValue(userInput, out City city);

            if (!getCity)
                Console.WriteLine($"There is no city with code, {userInput}");
            else
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
        }
    }
}
