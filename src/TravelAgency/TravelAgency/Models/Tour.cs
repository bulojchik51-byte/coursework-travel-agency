using System;

namespace TravelAgency.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public DateTime DepartureDate { get; set; }
        public Country Country { get; set; }
        public Agency Agency { get; set; }
    }
}