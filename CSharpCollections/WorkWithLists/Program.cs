using System;
using System.Collections.Generic;

namespace WorkWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\WorkWithLists\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            List<City> cities = csvReader.ReadAllCities();

            csvReader.RemoveCityTest(cities);

            //foreach (var city in cities)
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //wersja z pętlą FOR

            //for (int i = 0; i < cities.Count; i++)
            //{
            //    var city = cities[i];
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //wyświetlanie określonej ilości miast:

            //Console.Write("Enter, how many cities you want to diplay: ");
            //bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            //if (!inputIsInt || userInput <= 0)
            //{
            //    Console.WriteLine("You must enter a positve integer!");
            //    return;
            //}

            //int maxToDisplay = Math.Min(userInput, cities.Count);

            //for (int i = 0; i < maxToDisplay; i++)
            //{
            //    var city = cities[i];
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}
            
            //wyświetlanie określonej liczyby miast w kolejnych krokach 
            
            Console.Write("Enter, how many cities you want to diplay: ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);

            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must enter a positve integer!");
                return;
            }

            int maxToDisplay = Math.Min(userInput, cities.Count);

            for (int i = 0; i < cities.Count; i++)
            {
                if (i > 0 && (i % userInput == 0))
                {
                    Console.WriteLine("Hit enter to continue, to quit press anything else");
                    if (Console.ReadLine() != "")
                    {
                        break;
                    }

                }
                var city = cities[i];
                Console.WriteLine($"{i + 1} - {city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }

            // aby liczyć od końca musimy zmienić warunek pętli:

            //for (int i = cities.Count-1; i >= 0; i--)
            //{
            //    int displayIndex = cities.Count - 1 - i;
            //    if (displayIndex > 0 && (displayIndex % userInput == 0))
            //    {
            //        Console.WriteLine("Hit enter to continue, to quit press anything else");
            //        if (Console.ReadLine() != "")
            //        {
            //            break;
            //        }

            //    }
            //    var city = cities[i];
            //    Console.WriteLine($"{displayIndex + 1} - {city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}
        }
    }
}
