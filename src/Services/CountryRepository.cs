using System.Collections.Generic;
using System.Linq;
using BookApiProject.Contexts;
using BookApiProject.Models;

namespace BookApiProject.Services
{
    public class CountryRepository : ICountryRepository
    {
        private readonly BookDbContext _countryContext;

        public CountryRepository(BookDbContext context)
        {
            _countryContext = context;
        }

        public ICollection<Country> GetCountries()
        {
            return _countryContext.Countries.OrderBy(c => c.Id).ToList();
        }

        public Country GetCountry(int countryId)
        {
            return _countryContext.Countries.FirstOrDefault(c => c.Id == countryId);
        }

        public Country GetCountryOfAnAuthor(int authorId)
        {
            return _countryContext.Authors.Where(a => a.Id == authorId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Author> GetAuthorsFromACountry(int countryId)
        {
            return _countryContext.Authors.Where(c=>c.Country.Id==countryId).ToList();
        }

        public bool CountryExist(int countryId)
        {
            return _countryContext.Countries.Any(c => c.Id == countryId);
        }
    }
}