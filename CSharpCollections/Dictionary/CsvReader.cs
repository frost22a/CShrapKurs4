﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace Dictionary
{
    class CsvReader
    {
        private string csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }

        public Dictionary<string, City> ReadAllCities() 
        {
            var cities = new Dictionary<string, City>();

            using (StreamReader streamReader = new StreamReader(csvFilePath)) // użycie using powoduje zamknięcie StreamReadera po zakończeniu czytania pliku, 
                                                                              // jeżeli zostałby nadal otwarty , to inne progarmy nie miałyby dostepu do pliku population.csv
            {
                streamReader.ReadLine();
                
                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    //cities.Add(ReadCityFromCsvFile(csvLine).CityCode, ReadCityFromCsvFile(csvLine));// < - moja wersja

                    //wersja z wykładów - >
                    City city = ReadCityFromCsvFile(csvLine);
                    cities.Add(city.CityCode, city);
                }
                
            }
                return cities;
        }

        public City ReadCityFromCsvFile(string csvLine)
        {
            // tworzymy tablicę stringów, dla której separatorem jest ','
            string[] parts = csvLine.Split(new char[] { ',' }); // tu zamiast char[] można wpisać inne typy, a w nawiasach wypisać separatory. mozna też zostawić .Spilt(',')

            string cityName = parts[0];
            string cityCode = parts[1];
            string country = parts[2];
            int totalPopulation = int.Parse(parts[3]);
            int menPopulation = int.Parse(parts[4]);
            int womenPopulation = int.Parse(parts[5]);

            return new City(cityName, cityCode, country, totalPopulation, menPopulation, womenPopulation);        
        }
    }
}