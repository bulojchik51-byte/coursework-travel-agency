using System.Windows.Forms;
using TravelAgency.Models;
using TravelAgency.Services;

namespace TravelAgency.Forms
{
    public partial class BookingDetailsForm : Form
    {
        public bool Deleted { get; private set; } = false;
        private readonly Booking _booking;
        private readonly BookingService _bookingService;

        public BookingDetailsForm(Booking booking, BookingService bookingService)
        {
            InitializeComponent();

            _booking = booking;
            _bookingService = bookingService;

            titleLabel.Text = $"Бронь #{booking.Id}";
            lastNameLabel.Text = $"👤 Фамилия клиента: {booking.ClientLastName}";
            phoneLabel.Text = $"📞 Телефон: {booking.ClientPhone}";
            tourLabel.Text = $"✈ Тур: {booking.TourName}";
            tourDateLabel.Text = $"📅 Дата тура: {booking.TourDate}";
            tourPriceLabel.Text = $"💰 Цена тура: {booking.TourPrice} USD";
            bookingPriceLabel.Text = $"🎫 Цена бронирования: {booking.BookingPrice} USD";
            bookingDateLabel.Text = $"🗓 Дата брони: {booking.BookingDate:dd.MM.yyyy HH:mm}";
            statusLabel.Text = $"📋 Статус: {booking.Status}";

            deleteButton.Click += (s, e) =>
            {
                if (MessageBox.Show($"Удалить бронь #{booking.Id}?",
                    "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _bookingService.Delete(booking.Id);
                    Deleted = true;
                    this.Close();
                }
            };

            closeButton.Click += (s, e) => this.Close();
        }
    }
}