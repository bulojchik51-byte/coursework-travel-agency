using System.Collections.Generic;
using System.Linq;
using TravelAgency.Models;

namespace TravelAgency.Services
{
    public class CountryService
    {
        private List<Country> _countries = new List<Country>();

        public List<Country> GetAll() => _countries;

        public void Add(Country country)
        {
            country.Id = _countries.Count + 1;
            _countries.Add(country);
        }

        public void Update(Country updated)
        {
            var country = _countries.FirstOrDefault(c => c.Id == updated.Id);
            if (country != null)
            {
                country.Name = updated.Name;
                country.Description = updated.Description;
            }
        }

        public void Delete(int id)
        {
            var country = _countries.FirstOrDefault(c => c.Id == id);
            if (country != null)
                _countries.Remove(country);
        }

        public void AddDefault()
        {
            var defaults = new List<string> {
                "Турция", "Египет", "Испания",
                "Италия", "Греция", "Таиланд", "ОАЭ", "Франция"
            };
            foreach (var name in defaults)
                Add(new Country { Name = name });
        }
    }
}