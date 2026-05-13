using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgency.Models;

namespace TravelAgency.Services
{
    public class BookingService
    {
        private List<Booking> _bookings = new List<Booking>();

        public List<Booking> GetAll() => _bookings;
        public void AddLoaded(Booking booking)
        {
            _bookings.Add(booking);
        }

        public void Add(Booking booking)
        {
            booking.Id = _bookings.Count + 1;
            booking.BookingDate = DateTime.Now;
            booking.Status = "Ожидает";
            _bookings.Add(booking);
        }

        public void Delete(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null)
                _bookings.Remove(booking);
        }

        public void UpdateStatus(int id, string status)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null)
                booking.Status = status;
        }
    }
}