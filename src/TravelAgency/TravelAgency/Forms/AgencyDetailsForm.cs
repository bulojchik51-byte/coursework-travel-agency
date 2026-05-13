using System.Windows.Forms;
using System.Xml;
using TravelAgency.Models;
using TravelAgency.Services;

namespace TravelAgency.Forms
{
    public partial class AgencyDetailsForm : Form
    {
        public AgencyDetailsForm(Agency agency, BookingService bookingService)
        {
            InitializeComponent();

            nameLabel.Text = agency.Name;
            phoneLabel.Text = $"📞 Телефон: {agency.Phone}";
            emailLabel.Text = $"📧 Email: {agency.Email}";
            addressLabel.Text = $"📍 Адрес: {agency.Address}";

            int bookingsCount = bookingService.GetAll()
                .FindAll(b => b.Tour?.Agency?.Id == agency.Id).Count;
            bookingsLabel.Text = $"📋 Количество броней: {bookingsCount}";
        }
    }
}