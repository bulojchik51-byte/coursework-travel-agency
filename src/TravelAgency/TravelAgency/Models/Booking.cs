using System;

namespace TravelAgency.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public Tour Tour { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
    }
}