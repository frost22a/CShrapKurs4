using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_CollectionsOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\user\source\repos\BeginningCsharpCollections\8 CollectionsOfCollections\population.csv";

            CsvReader csvReader = new CsvReader(filePath);

            Dictionary<string, List<City>> citys = csvReader.ReadAllCiyts();

            foreach (string country in citys.Keys)
                Console.WriteLine(country);

            while(true)
            {
                Console.WriteLine("Which country do you want? ");
                string chosenCountry = Console.ReadLine();

                if (chosenCountry == "")
                    break;

                if (citys.ContainsKey(chosenCountry))
                {
                    foreach (City city in citys[chosenCountry].Take(10))
                        Console.WriteLine($"{city.TotalPopulation: ### ### ###} : {city.CityName}");
                }
                else
                    Console.WriteLine("That is not a valid country");
            }          
        }
    }
}
