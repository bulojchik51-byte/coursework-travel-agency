using System.Windows.Forms;
using System.Xml;
using TravelAgency.Models;

namespace TravelAgency.Forms
{
    public partial class TourDetailsForm : Form
    {
        public TourDetailsForm(Tour tour)
        {
            InitializeComponent();

            nameLabel.Text = tour.Name;
            countryLabel.Text = $"🌍 Страна: {tour.CountryName}";
            agencyLabel.Text = $"🏢 Агентство: {tour.AgencyName}";
            priceLabel.Text = $"💰 Цена: {tour.Price} USD";
            durationLabel.Text = $"📅 Длительность: {tour.DurationDays} дней";
            departureDateLabel.Text = $"✈ Дата вылета: {tour.DepartureDate:dd.MM.yyyy}";
            citiesLabel.Text = string.IsNullOrEmpty(tour.Cities)
    ? ""
    : $"🏙 Города: {tour.Cities}";
            citiesLabel.Visible = !string.IsNullOrEmpty(tour.Cities);
            descriptionLabel.Text = $"📝 Описание: {tour.Description}";
        }
    }
}