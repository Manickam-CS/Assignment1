using Assignment1.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressDataController : ControllerBase
    {
        PopulateAddressData populateAddressData = new PopulateAddressData();

        [HttpGet]
        [Route("Countries")]
        public List<Countries> CountryDetails()
        {
            return populateAddressData.GetCountries();
        }

        [HttpGet]
        [Route("Cities")]
        public List<Cities> CityDetails(int countryID)
        {
            return populateAddressData.GetCities(countryID);
        }
    }
}
