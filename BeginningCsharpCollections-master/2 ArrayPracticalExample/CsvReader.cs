using System.IO;

namespace _2_ArrayPracticalExample
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public City[] ReadFirstNCiyts(int nCitys)
        {
            City[] citys = new City[nCitys];

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                // read header line
                streamReader.ReadLine();

                for (int i = 0; i < nCitys; i++)
                {
                    string csvLine = streamReader.ReadLine();
                    citys[i] = ReadCityFromCsvLine(csvLine);
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
