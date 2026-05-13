using System;

namespace TravelAgency.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string ClientLastName { get; set; }
        public string ClientPhone { get; set; }
        public Tour Tour { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }

        public string TourName => Tour?.Name ?? "—";
        public string TourDate => Tour?.DepartureDate.ToString("dd.MM.yyyy") ?? "—";
        public decimal TourPrice => Tour?.Price ?? 0;
        public decimal BookingPrice => 50;
    }
}