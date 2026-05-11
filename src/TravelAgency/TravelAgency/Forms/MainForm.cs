using System;
using System.Windows.Forms;
using TravelAgency.Services;
using TravelAgency.Storage;

namespace TravelAgency.Forms
{
    public partial class MainForm : Form
    {
        private readonly AgencyService _agencyService;
        private readonly TourService _tourService;
        private readonly BookingService _bookingService;
        private readonly JsonStorage _storage;

        public MainForm()
        {
            InitializeComponent();

            _storage = new JsonStorage();
            _agencyService = new AgencyService();
            _tourService = new TourService();
            _bookingService = new BookingService();
        }
    }
}