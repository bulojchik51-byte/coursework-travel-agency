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
        private readonly CountryService _countryService;
        private readonly JsonStorage _storage;

        public MainForm()
        {
            InitializeComponent();

            _storage = new JsonStorage();
            _agencyService = new AgencyService();
            _tourService = new TourService();
            _bookingService = new BookingService();
            _countryService = new CountryService();

            // Навигация
            navHomeButton.Click += (s, e) => ShowPanel(homePanel);
            navAgenciesButton.Click += (s, e) => ShowPanel(agenciesPanel);
            navToursButton.Click += (s, e) => ShowPanel(toursPanel);
            navCountriesButton.Click += (s, e) => ShowPanel(countriesPanel);
            navBookingsButton.Click += (s, e) => ShowPanel(bookingsPanel);

            // Агентства
            addAgencyButton.Click += AddAgencyButton_Click;
            editAgencyButton.Click += EditAgencyButton_Click;
            deleteAgencyButton.Click += DeleteAgencyButton_Click;
            searchAgencyButton.Click += SearchAgencyButton_Click;

            // Туры
            addTourButton.Click += AddTourButton_Click;
            editTourButton.Click += EditTourButton_Click;
            deleteTourButton.Click += DeleteTourButton_Click;
            searchTourButton.Click += SearchTourButton_Click;

            // Страны
            addCountryButton.Click += AddCountryButton_Click;
            editCountryButton.Click += EditCountryButton_Click;
            deleteCountryButton.Click += DeleteCountryButton_Click;

            // Бронирования
            addBookingButton.Click += AddBookingButton_Click;
            deleteBookingButton.Click += DeleteBookingButton_Click;
            confirmBookingButton.Click += ConfirmBookingButton_Click;
            

            this.FormClosing += (s, e) => SaveData();

            LoadData();
            ShowPanel(homePanel);
        }

        private void ShowPanel(Panel panel)
        {
            homePanel.Visible = false;
            agenciesPanel.Visible = false;
            toursPanel.Visible = false;
            countriesPanel.Visible = false;
            bookingsPanel.Visible = false;

            panel.Visible = true;

            // Подсветка активной кнопки
            foreach (Control ctrl in sidePanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = System.Drawing.Color.FromArgb(31, 43, 71);
                    btn.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
                }
            }

            Button activeBtn = null;
            if (panel == homePanel) activeBtn = navHomeButton;
            else if (panel == agenciesPanel) activeBtn = navAgenciesButton;
            else if (panel == toursPanel) activeBtn = navToursButton;
            else if (panel == countriesPanel) activeBtn = navCountriesButton;
            else if (panel == bookingsPanel) activeBtn = navBookingsButton;

            if (activeBtn != null)
            {
                activeBtn.BackColor = System.Drawing.Color.FromArgb(52, 73, 120);
                activeBtn.ForeColor = System.Drawing.Color.White;
            }

            if (panel == homePanel) UpdateStats();
            if (panel == agenciesPanel) LoadAgenciesToGrid();
            if (panel == toursPanel) LoadToursToGrid();
            if (panel == countriesPanel) LoadCountriesToGrid();
            if (panel == bookingsPanel) LoadBookingsToGrid();
        }

        private void UpdateStats()
        {
            agenciesCountLabel.Text = $"🏢 Агентств:\n{_agencyService.GetAll().Count}";
            toursCountLabel.Text = $"✈ Туров:\n{_tourService.GetAll().Count}";
            bookingsCountLabel.Text = $"📋 Броней:\n{_bookingService.GetAll().Count}";
            countriesCountLabel.Text = $"🌍 Стран:\n{_countryService.GetAll().Count}";
        }

        // ═══════════════════════════════
        // АГЕНТСТВА
        // ═══════════════════════════════
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
                MessageBox.Show("Выберите агентство!");
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
                MessageBox.Show("Выберите агентство!");
                return;
            }
            var agency = agenciesGrid.SelectedRows[0].DataBoundItem as Agency;
            if (agency == null) return;

            if (MessageBox.Show($"Удалить '{agency.Name}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _agencyService.Delete(agency.Id);
                LoadAgenciesToGrid();
            }
        }

        private void SearchAgencyButton_Click(object sender, EventArgs e)
        {
            string query = searchAgencyBox.Text.Trim();
            agenciesGrid.DataSource = null;
            agenciesGrid.DataSource = string.IsNullOrEmpty(query)
                ? _agencyService.GetAll()
                : _agencyService.Search(query);
        }

        // ═══════════════════════════════
        // ТУРЫ
        // ═══════════════════════════════
        private void LoadToursToGrid()
        {
            toursGrid.DataSource = null;
            toursGrid.DataSource = _tourService.GetAll();
        }

        private void AddTourButton_Click(object sender, EventArgs e)
        {
            var form = new TourForm(_agencyService.GetAll(), _countryService.GetAll());
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
                MessageBox.Show("Выберите тур!");
                return;
            }
            var tour = toursGrid.SelectedRows[0].DataBoundItem as Tour;
            if (tour == null) return;

            var form = new TourForm(_agencyService.GetAll(), _countryService.GetAll(), tour);
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
                MessageBox.Show("Выберите тур!");
                return;
            }
            var tour = toursGrid.SelectedRows[0].DataBoundItem as Tour;
            if (tour == null) return;

            if (MessageBox.Show($"Удалить тур '{tour.Name}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _tourService.Delete(tour.Id);
                LoadToursToGrid();
            }
        }

        private void SearchTourButton_Click(object sender, EventArgs e)
        {
            string query = searchTourBox.Text.Trim();
            toursGrid.DataSource = null;
            toursGrid.DataSource = string.IsNullOrEmpty(query)
                ? _tourService.GetAll()
                : _tourService.Search(query);
        }
      
        // ═══════════════════════════════
        // СТРАНЫ
        // ═══════════════════════════════
        private void LoadCountriesToGrid()
        {
            countriesGrid.DataSource = null;
            countriesGrid.DataSource = _countryService.GetAll();
        }

        private void AddCountryButton_Click(object sender, EventArgs e)
        {
            var form = new CountryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _countryService.Add(form.Country);
                LoadCountriesToGrid();
            }
        }

        private void EditCountryButton_Click(object sender, EventArgs e)
        {
            if (countriesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите страну!");
                return;
            }
            var country = countriesGrid.SelectedRows[0].DataBoundItem as Country;
            if (country == null) return;

            var form = new CountryForm(country);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _countryService.Update(form.Country);
                LoadCountriesToGrid();
            }
        }

        private void DeleteCountryButton_Click(object sender, EventArgs e)
        {
            if (countriesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите страну!");
                return;
            }
            var country = countriesGrid.SelectedRows[0].DataBoundItem as Country;
            if (country == null) return;

            if (MessageBox.Show($"Удалить '{country.Name}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _countryService.Delete(country.Id);
                LoadCountriesToGrid();
            }
        }

        // ═══════════════════════════════
        // БРОНИРОВАНИЯ
        // ═══════════════════════════════
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
                MessageBox.Show("Выберите бронирование!");
                return;
            }
            var booking = bookingsGrid.SelectedRows[0].DataBoundItem as Booking;
            if (booking == null) return;

            if (MessageBox.Show($"Удалить бронь '{booking.ClientName}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _bookingService.Delete(booking.Id);
                LoadBookingsToGrid();
            }
        }

        private void ConfirmBookingButton_Click(object sender, EventArgs e)
        {
            if (bookingsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование!");
                return;
            }
            var booking = bookingsGrid.SelectedRows[0].DataBoundItem as Booking;
            if (booking == null) return;

            _bookingService.UpdateStatus(booking.Id, "Подтверждено");
            LoadBookingsToGrid();
            MessageBox.Show("Бронирование подтверждено!");
        }

        // ═══════════════════════════════
        // СОХРАНЕНИЕ / ЗАГРУЗКА
        // ═══════════════════════════════
        private void SaveData()
        {
            _storage.Save("agencies.json", _agencyService.GetAll());
            _storage.Save("tours.json", _tourService.GetAll());
            _storage.Save("bookings.json", _bookingService.GetAll());
            _storage.Save("countries.json", _countryService.GetAll());
        }

        private void LoadData()
        {
            try
            {
                var agencies = _storage.Load<Agency>("agencies.json");
                foreach (var a in agencies) _agencyService.Add(a);

                var tours = _storage.Load<Tour>("tours.json");
                foreach (var t in tours) _tourService.Add(t);

                var bookings = _storage.Load<Booking>("bookings.json");
                foreach (var b in bookings) _bookingService.Add(b);

                var countries = _storage.Load<Country>("countries.json");
                if (countries.Count == 0)
                {
                    _countryService.AddDefault();
                }
                else
                {
                    foreach (var c in countries) _countryService.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

    }

}