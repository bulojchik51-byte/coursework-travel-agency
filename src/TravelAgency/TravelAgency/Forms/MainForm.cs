using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelAgency.Models;
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

            LoadAgenciesToGrid();

            addAgencyButton.Click += AddAgencyButton_Click;
            editAgencyButton.Click += EditAgencyButton_Click;
            deleteAgencyButton.Click += DeleteAgencyButton_Click;
            searchAgencyButton.Click += SearchAgencyButton_Click;
            exitMenuItem.Click += (s, e) => Application.Exit();
            addTourButton.Click += AddTourButton_Click;
            editTourButton.Click += EditTourButton_Click;
            deleteTourButton.Click += DeleteTourButton_Click;
            searchTourButton.Click += SearchTourButton_Click;

            LoadToursToGrid();
            addBookingButton.Click += AddBookingButton_Click;
            deleteBookingButton.Click += DeleteBookingButton_Click;
            confirmBookingButton.Click += ConfirmBookingButton_Click;

            LoadBookingsToGrid();
        }

        private void LoadAgenciesToGrid()
        {
            agenciesGrid.DataSource = null;
            agenciesGrid.DataSource = _agencyService.GetAll();
        }

        private void AddAgencyButton_Click(object sender, EventArgs e)
        {
            var form = new AgencyForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _agencyService.Add(form.Agency);
                LoadAgenciesToGrid();
            }
        }

        private void EditAgencyButton_Click(object sender, EventArgs e)
        {
            if (agenciesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите агентство для редактирования!");
                return;
            }

            var agency = agenciesGrid.SelectedRows[0].DataBoundItem as Agency;
            if (agency == null) return;

            var form = new AgencyForm(agency);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _agencyService.Update(form.Agency);
                LoadAgenciesToGrid();
            }
        }

        private void DeleteAgencyButton_Click(object sender, EventArgs e)
        {
            if (agenciesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите агентство для удаления!");
                return;
            }

            var agency = agenciesGrid.SelectedRows[0].DataBoundItem as Agency;
            if (agency == null) return;

            var result = MessageBox.Show(
                $"Удалить агентство '{agency.Name}'?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                _agencyService.Delete(agency.Id);
                LoadAgenciesToGrid();
            }
        }

        private void SearchAgencyButton_Click(object sender, EventArgs e)
        {
            string query = searchAgencyBox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LoadAgenciesToGrid();
                return;
            }

            agenciesGrid.DataSource = null;
            agenciesGrid.DataSource = _agencyService.Search(query);
        }
        private void LoadToursToGrid()
        {
            toursGrid.DataSource = null;
            toursGrid.DataSource = _tourService.GetAll();
        }

        private void AddTourButton_Click(object sender, EventArgs e)
        {
            var form = new TourForm(
                _agencyService.GetAll(),
                _tourService.GetCountries()
            );
            if (form.ShowDialog() == DialogResult.OK)
            {
                _tourService.Add(form.Tour);
                LoadToursToGrid();
            }
        }

        private void EditTourButton_Click(object sender, EventArgs e)
        {
            if (toursGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тур для редактирования!");
                return;
            }

            var tour = toursGrid.SelectedRows[0].DataBoundItem as Tour;
            if (tour == null) return;

            var form = new TourForm(
                _agencyService.GetAll(),
                _tourService.GetCountries(),
                tour
            );
            if (form.ShowDialog() == DialogResult.OK)
            {
                _tourService.Update(form.Tour);
                LoadToursToGrid();
            }
        }

        private void DeleteTourButton_Click(object sender, EventArgs e)
        {
            if (toursGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тур для удаления!");
                return;
            }

            var tour = toursGrid.SelectedRows[0].DataBoundItem as Tour;
            if (tour == null) return;

            var result = MessageBox.Show(
                $"Удалить тур '{tour.Name}'?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                _tourService.Delete(tour.Id);
                LoadToursToGrid();
            }
        }

        private void SearchTourButton_Click(object sender, EventArgs e)
        {
            string query = searchTourBox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LoadToursToGrid();
                return;
            }

            toursGrid.DataSource = null;
            toursGrid.DataSource = _tourService.Search(query);
        }
        private void LoadBookingsToGrid()
        {
            bookingsGrid.DataSource = null;
            bookingsGrid.DataSource = _bookingService.GetAll();
        }

        private void AddBookingButton_Click(object sender, EventArgs e)
        {
            var tours = _tourService.GetAll();
            if (tours.Count == 0)
            {
                MessageBox.Show("Сначала добавьте туры!");
                return;
            }

            var form = new BookingForm(tours);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bookingService.Add(form.Booking);
                LoadBookingsToGrid();
            }
        }

        private void DeleteBookingButton_Click(object sender, EventArgs e)
        {
            if (bookingsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование для удаления!");
                return;
            }

            var booking = bookingsGrid.SelectedRows[0].DataBoundItem as Booking;
            if (booking == null) return;

            var result = MessageBox.Show(
                $"Удалить бронирование клиента '{booking.ClientName}'?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                _bookingService.Delete(booking.Id);
                LoadBookingsToGrid();
            }
        }

        private void ConfirmBookingButton_Click(object sender, EventArgs e)
        {
            if (bookingsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование для подтверждения!");
                return;
            }

            var booking = bookingsGrid.SelectedRows[0].DataBoundItem as Booking;
            if (booking == null) return;

            _bookingService.UpdateStatus(booking.Id, "Подтверждено");
            LoadBookingsToGrid();
            MessageBox.Show("Бронирование подтверждено!");
        }
    }
}