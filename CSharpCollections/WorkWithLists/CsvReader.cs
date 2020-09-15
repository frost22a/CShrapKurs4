using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace WorkWithLists
{
    class CsvReader
    {
        private string csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }

        public List<City> ReadAllCities() 
        {
            List<City> cities = new List<City>();

            using (StreamReader streamReader = new StreamReader(csvFilePath)) // użycie using powoduje zamknięcie StreamReadera po zakończeniu czytania pliku, 
                                                                              // jeżeli zostałby nadal otwarty , to inne progarmy nie miałyby dostepu do pliku population.csv
            {
                streamReader.ReadLine();
                
                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    cities.Add(ReadCityFromCsvFile(csvLine));
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

        public void RemoveCityTest(List<City> cities)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i].CityName.Contains("Test"))
                    cities.RemoveAt(i);
                    i--; //-> dobre rozwiązanie, ale lepiej zastosować listowanie od góry do dołu:
            }
        }

        public void RemoveCityTest2(List<City> cities)
        {
            for (int i = cities.Count - 1; i >= 0; i--)
            {
                if (cities[i].CityName.Contains("Test"))
                    cities.RemoveAt(i);
                // i--; -> dobre rozwiązanie, ale lepiej zastosować listowanie od góry do dołu:
            }
        }

        // zamiast korzystać z pętli for można użyć RemoveAll():


        public void RemoveCityTest3(List<City> cities)
        {
            cities.RemoveAll(c => c.CityName.Contains("Test")); //predykat!!! za pomocą lambdy
        }
        public void RemoveCityTest4(List<City> cities)
        {
            cities.RemoveAll(predykat); // predykat wpisany za pomocą metody zwracającej bool 
        }

        public static bool predykat(City city) 
        {
            return city.CityName.Contains("Test");
        }

    }
}
