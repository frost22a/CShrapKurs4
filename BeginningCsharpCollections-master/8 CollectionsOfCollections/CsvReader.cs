using System.Collections.Generic;
using System.IO;

namespace _8_CollectionsOfCollections
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Dictionary<string, List<City>> ReadAllCiyts()
        {
            var citys = new Dictionary<string, List<City>>();

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                // read header line
                streamReader.ReadLine();

                string csvLine;

                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    City city = ReadCityFromCsvLine(csvLine);

                    if (citys.ContainsKey(city.Country))
                    {
                        citys[city.Country].Add(city);
                    }
                    else
                    {
                        List<City> citysInCountry = new List<City>() { city };
                        citys.Add(city.Country, citysInCountry);
                    }
                }
            }

            return citys;
        }

        public City ReadCityFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

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
