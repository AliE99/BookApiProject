using System.Linq;
using BookApiProject.Services;
using Microsoft.AspNetCore.Mvc;
namespace BookApiProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController: ControllerBase
    {
        private ICountryRepository _countryRepository;

        public CountriesController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        
        //api/countries
        [HttpGet]
        public IActionResult GetCountries()
        {
            var countries = _countryRepository.GetCountries().ToList();
            return Ok(countries);    
        } 
    }
}