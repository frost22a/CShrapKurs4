using System.Collections.Generic;
using System.IO;

namespace _7_LINQ
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<City> ReadAllCiyts()
        {
            List<City> citys = new List<City>();

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                // read header line
                streamReader.ReadLine();

                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    citys.Add(ReadCityFromCsvLine(csvLine));
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

        public void RemoveTestCitys(List<City> citys)
        {
            citys.RemoveAll(c => c.CityName.Contains("Test"));
        }
    }
}
