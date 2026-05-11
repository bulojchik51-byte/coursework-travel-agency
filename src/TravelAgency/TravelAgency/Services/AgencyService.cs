using TravelAgency.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace TravelAgency.Services
{
    public class AgencyService
    {
        private List<Agency> _agencies = new List<Agency>();

        public List<Agency> GetAll() => _agencies;

        public void Add(Agency agency)
        {
            agency.Id = _agencies.Count + 1;
            _agencies.Add(agency);
        }

        public void Update(Agency updated)
        {
            var agency = _agencies.FirstOrDefault(a => a.Id == updated.Id);
            if (agency != null)
            {
                agency.Name = updated.Name;
                agency.Phone = updated.Phone;
                agency.Email = updated.Email;
                agency.Address = updated.Address;
            }
        }

        public void Delete(int id)
        {
            var agency = _agencies.FirstOrDefault(a => a.Id == id);
            if (agency != null)
                _agencies.Remove(agency);
        }

        public List<Agency> Search(string query)
        {
            return _agencies
                .Where(a => a.Name.ToLower().Contains(query.ToLower()))
                .ToList();
        }
    }
}