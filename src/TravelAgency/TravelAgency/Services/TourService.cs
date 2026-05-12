using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgency.Models;

namespace TravelAgency.Services
{
    public class TourService
    {
        private List<Tour> _tours = new List<Tour>();

        public List<Tour> GetAll() => _tours;

        public void Add(Tour tour)
        {
            tour.Id = _tours.Count + 1;
            _tours.Add(tour);
        }

        public void Update(Tour updated)
        {
            var tour = _tours.FirstOrDefault(t => t.Id == updated.Id);
            if (tour != null)
            {
                tour.Name = updated.Name;
                tour.Description = updated.Description;
                tour.Price = updated.Price;
                tour.DurationDays = updated.DurationDays;
                tour.DepartureDate = updated.DepartureDate;
                tour.Country = updated.Country;
                tour.Agency = updated.Agency;
            }
        }

        public void Delete(int id)
        {
            var tour = _tours.FirstOrDefault(t => t.Id == id);
            if (tour != null)
                _tours.Remove(tour);
        }

        public List<Tour> Search(string query)
        {
            return _tours
                .Where(t => t.Name.ToLower().Contains(query.ToLower()) ||
                            t.Country.Name.ToLower().Contains(query.ToLower()))
                .ToList();
        }
        
    }
}