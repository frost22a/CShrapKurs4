using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsOfCollections
{
    class City
    {
        public string CityName { get; }
        public string CityCode { get; }
        public string Country { get; }
        public int TotalPopulation { get; }
        public int MenPopulation { get; }
        public int WomenPopulation { get; set; }
            
        public City
                (string cityName,
                string cityCode,
                string country,
                int totalPopulation,
                int menPopulation,
                int womenPopulation)
        {
            this.CityName = cityName;
            this.CityCode = cityCode;
            this.Country = country;
            this.TotalPopulation = totalPopulation;
            this.MenPopulation = menPopulation;
            this.WomenPopulation = womenPopulation;
        }
    }
}
