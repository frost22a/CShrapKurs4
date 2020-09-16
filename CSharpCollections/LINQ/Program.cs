using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"D:\PROGRAMOWANIE\C#\CShrapKurs4\CSharpCollections\WorkWithLists\population.csv"; //@ -> "czytanie dosłowne"

            CsvReader csvReader = new CsvReader(filePath);

            List<City> cities = csvReader.ReadAllCities();

            //linQ - funkcja take()

            //foreach (var city in cities.Take(7))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //orederby(): 

            //foreach (var city in cities.OrderBy(c => c.CityName))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //orderby + take:

            //foreach (var city in cities.OrderBy(c => c.CityName).Take(5))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //Console.WriteLine();

            //foreach (var city in cities.Take(5).OrderBy(c => c.CityName))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //Console.WriteLine();

            //// polecenie where oraz różnica w wyniku zastosowania różnej kolejności poleceń:

            //foreach (var city in cities.Take(10).Where(c => !c.CityName.Contains("Test")))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //Console.WriteLine();

            //foreach (var city in cities.Where(c => !c.CityName.Contains("Test")).Take(10))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //Console.WriteLine();

            //foreach (var city in cities.Where(c => c.CityName.Equals("Mazowieckie") && c.CityCode.Equals("MAZ") && c.Country.Equals("Polska")))
            //{
            //    Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            //}

            //Console.WriteLine();

            //obliczenia w linq:

            //Console.WriteLine($"{cities.Max(c => c.MenPopulation): ### ### ###}");
            //Console.WriteLine(cities.Min(c => c.WomenPopulation));
            //Console.WriteLine(cities.Sum(c => c.TotalPopulation));
            //Console.WriteLine(cities.Average(c => c.MenPopulation));
            //Console.WriteLine($"{cities.All(c => c.TotalPopulation > 2000000): ### ### ###}");
            //Console.WriteLine($"{cities.Any(c => c.TotalPopulation > 2000000): ### ### ###}");

            //Składnia w LINQ:

            var filtredCities = cities.Where(c => !c.CityName.Contains("Test")).Take(10);

            // teraz zapiszemy to samo zapytanie, ale używając składni linq:

            var filtredCities2 = (from city in cities
                                  where !city.CityName.Contains("Test")
                                  select city).Take(10);                            


            foreach (var city in filtredCities)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }

            Console.WriteLine();

            foreach (var city in filtredCities2)
            {
                Console.WriteLine($"{city.TotalPopulation:### ### ###} : {city.CityCode} : {city.CityName}");
            }
            City city2;
            

        }
    }
}
