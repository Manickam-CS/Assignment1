using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.BusinessLogic
{
    public class PopulateAddressData
    {
        List<Countries> lstCountry = new List<Countries>();
        List<Cities> lstCities = new List<Cities>();
        public PopulateAddressData()
        {
            lstCountry.Add(new Countries { CountryID = 1, Country = "India" });
            lstCountry.Add(new Countries { CountryID = 2, Country = "United Kingdom" });
            lstCountry.Add(new Countries { CountryID = 3, Country = "United States" });

            lstCities.Add(new Cities { CityId = 1, City = "Delhi" , CountryId =1 });
            lstCities.Add(new Cities { CityId = 2, City = "Mumbai", CountryId = 1 });
            lstCities.Add(new Cities { CityId = 3, City = "Chennai", CountryId = 1 });

            lstCities.Add(new Cities { CityId = 4, City = "London", CountryId = 2 });
            lstCities.Add(new Cities { CityId = 5, City = "Belfast", CountryId = 2 });
            lstCities.Add(new Cities { CityId = 6, City = "Manchester", CountryId = 2 });

            lstCities.Add(new Cities { CityId = 7, City = "Washington", CountryId = 3 });
            lstCities.Add(new Cities { CityId = 8, City = "New York", CountryId = 3 });
            lstCities.Add(new Cities { CityId = 9, City = "Las Angles", CountryId = 3 });
        }

        public List<Countries> GetCountries()
        {   
            return lstCountry;
        }

        public List<Cities> GetCities(int countryID)
        {
            return lstCities.Where(cities => cities.CountryId == countryID).ToList();
        }
    }
}
