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
        private System.Windows.Forms.Timer _fadeTimer;
        private Panel _targetPanel;
        private int _opacity = 0;

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
            SetupNavButtonHover(navHomeButton);
            SetupNavButtonHover(navAgenciesButton);
            SetupNavButtonHover(navToursButton);
            SetupNavButtonHover(navCountriesButton);
            SetupNavButtonHover(navBookingsButton);

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
            toursGrid.CellDoubleClick += ToursGrid_CellDoubleClick;
            agenciesGrid.CellDoubleClick += AgenciesGrid_CellDoubleClick;

            // Страны
            addCountryButton.Click += AddCountryButton_Click;
            editCountryButton.Click += EditCountryButton_Click;
            deleteCountryButton.Click += DeleteCountryButton_Click;

            // Бронирования
            addBookingButton.Click += AddBookingButton_Click;
            
            confirmBookingButton.Click += ConfirmBookingButton_Click;
            bookingsGrid.CellDoubleClick += BookingsGrid_CellDoubleClick;
            cancelBookingButton.Click += CancelBookingButton_Click;

            this.FormClosing += (s, e) => SaveData();
            _fadeTimer = new System.Windows.Forms.Timer();
            _fadeTimer.Interval = 15;
            _fadeTimer.Tick += FadeTimer_Tick;

            LoadData();
            this.Resize += MainForm_Resize;
            ShowPanel(homePanel);
        }

        private void ShowPanel(Panel panel)
        {
            if (_targetPanel == panel) return;

            _targetPanel = panel;

            homePanel.Visible = false;
            agenciesPanel.Visible = false;
            toursPanel.Visible = false;
            countriesPanel.Visible = false;
            bookingsPanel.Visible = false;

            // Подсветка активной кнопки
            foreach (Control ctrl in sidePanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
                    btn.ForeColor = System.Drawing.Color.FromArgb(150, 175, 220);
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

            panel.Visible = true;
            panel.BringToFront();

            // Запуск анимации
            _opacity = 0;
            _fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            _opacity += 25;
            if (_opacity >= 255)
            {
                _opacity = 255;
                _fadeTimer.Stop();
            }

            if (_targetPanel != null)
            {
                foreach (Control ctrl in _targetPanel.Controls)
                {
                    if (ctrl is DataGridView grid)
                    {
                        grid.BackgroundColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        private void UpdateStats()
        {
            agenciesCountLabel.Text = $"🏢\nАгентства\n{_agencyService.GetAll().Count}";
            toursCountLabel.Text = $"✈\nТуры\n{_tourService.GetAll().Count}";
            bookingsCountLabel.Text = $"📋\nБронирования\n{_bookingService.GetAll().Count}";
            countriesCountLabel.Text = $"🌍\nСтраны\n{_countryService.GetAll().Count}";
        }

        // ═══════════════════════════════
        // АГЕНТСТВА
        // ═══════════════════════════════
        private void LoadAgenciesToGrid()
        {
            agenciesGrid.DataSource = null;
            agenciesGrid.DataSource = _agencyService.GetAll();

            if (agenciesGrid.Columns.Contains("Id")) agenciesGrid.Columns["Id"].HeaderText = "ID";
            if (agenciesGrid.Columns.Contains("Name")) agenciesGrid.Columns["Name"].HeaderText = "Название";
            if (agenciesGrid.Columns.Contains("Phone")) agenciesGrid.Columns["Phone"].HeaderText = "Телефон";
            if (agenciesGrid.Columns.Contains("Email")) agenciesGrid.Columns["Email"].HeaderText = "Email";
            if (agenciesGrid.Columns.Contains("Address")) agenciesGrid.Columns["Address"].HeaderText = "Адрес";
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

            if (toursGrid.Columns.Contains("Country"))
                toursGrid.Columns["Country"].Visible = false;
            if (toursGrid.Columns.Contains("Agency"))
                toursGrid.Columns["Agency"].Visible = false;
            if (toursGrid.Columns.Contains("Cities"))
                toursGrid.Columns["Cities"].Visible = false;

            if (toursGrid.Columns.Contains("Id")) toursGrid.Columns["Id"].HeaderText = "ID";
            if (toursGrid.Columns.Contains("Name")) toursGrid.Columns["Name"].HeaderText = "Название";
            if (toursGrid.Columns.Contains("Description")) toursGrid.Columns["Description"].HeaderText = "Описание";
            if (toursGrid.Columns.Contains("Price")) toursGrid.Columns["Price"].HeaderText = "Цена";
            if (toursGrid.Columns.Contains("DurationDays")) toursGrid.Columns["DurationDays"].HeaderText = "Дней";
            if (toursGrid.Columns.Contains("DepartureDate")) toursGrid.Columns["DepartureDate"].HeaderText = "Дата вылета";
            if (toursGrid.Columns.Contains("CountryName")) toursGrid.Columns["CountryName"].HeaderText = "Страна";
            if (toursGrid.Columns.Contains("AgencyName")) toursGrid.Columns["AgencyName"].HeaderText = "Агентство";
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

            if (countriesGrid.Columns.Contains("VisaRequired"))
                countriesGrid.Columns["VisaRequired"].Visible = false;

            if (countriesGrid.Columns.Contains("Id")) countriesGrid.Columns["Id"].HeaderText = "ID";
            if (countriesGrid.Columns.Contains("Name")) countriesGrid.Columns["Name"].HeaderText = "Название";
            if (countriesGrid.Columns.Contains("Description")) countriesGrid.Columns["Description"].HeaderText = "Описание";
            if (countriesGrid.Columns.Contains("VisaStatus")) countriesGrid.Columns["VisaStatus"].HeaderText = "Виза из Беларуси";
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

            if (bookingsGrid.Columns.Contains("Tour"))
                bookingsGrid.Columns["Tour"].Visible = false;

            if (bookingsGrid.Columns.Contains("Id")) bookingsGrid.Columns["Id"].HeaderText = "ID";
            if (bookingsGrid.Columns.Contains("ClientLastName")) bookingsGrid.Columns["ClientLastName"].HeaderText = "Фамилия";
            if (bookingsGrid.Columns.Contains("ClientPhone")) bookingsGrid.Columns["ClientPhone"].HeaderText = "Телефон";
            if (bookingsGrid.Columns.Contains("TourName")) bookingsGrid.Columns["TourName"].HeaderText = "Тур";
            if (bookingsGrid.Columns.Contains("TourDate")) bookingsGrid.Columns["TourDate"].HeaderText = "Дата тура";
            if (bookingsGrid.Columns.Contains("TourPrice")) bookingsGrid.Columns["TourPrice"].HeaderText = "Цена тура";
            if (bookingsGrid.Columns.Contains("BookingPrice")) bookingsGrid.Columns["BookingPrice"].HeaderText = "Цена брони";
            if (bookingsGrid.Columns.Contains("BookingDate")) bookingsGrid.Columns["BookingDate"].HeaderText = "Дата брони";
            if (bookingsGrid.Columns.Contains("Status")) bookingsGrid.Columns["Status"].HeaderText = "Статус";

            bookingsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            bookingsGrid.Columns["BookingPrice"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            if (bookingsGrid.Columns.Contains("Id")) bookingsGrid.Columns["Id"].Width = 50;
            if (bookingsGrid.Columns.Contains("ClientLastName")) bookingsGrid.Columns["ClientLastName"].Width = 120;
            if (bookingsGrid.Columns.Contains("ClientPhone")) bookingsGrid.Columns["ClientPhone"].Width = 120;
            if (bookingsGrid.Columns.Contains("BookingDate")) bookingsGrid.Columns["BookingDate"].Width = 160;
            if (bookingsGrid.Columns.Contains("Status")) bookingsGrid.Columns["Status"].Width = 100;
            if (bookingsGrid.Columns.Contains("TourName")) bookingsGrid.Columns["TourName"].Width = 180;
            if (bookingsGrid.Columns.Contains("TourDate")) bookingsGrid.Columns["TourDate"].Width = 110;
            if (bookingsGrid.Columns.Contains("TourPrice")) bookingsGrid.Columns["TourPrice"].Width = 100;
            if (bookingsGrid.Columns.Contains("BookingPrice")) bookingsGrid.Columns["BookingPrice"].Width = 110;
            bookingsGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            bookingsGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            bookingsGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            bookingsGrid.EnableHeadersVisualStyles = false;
            bookingsGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            bookingsGrid.BackgroundColor = System.Drawing.Color.White;
            bookingsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bookingsGrid.RowHeadersVisible = false;
            bookingsGrid.CellFormatting += BookingsGrid_CellFormatting;
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

            if (MessageBox.Show($"Удалить бронь '{booking.ClientLastName}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
        private void MainForm_Resize(object sender, EventArgs e)
        {
            int w = mainPanel.Width - 40;
            int h = mainPanel.Height - 140;

            agenciesGrid.Size = new System.Drawing.Size(w, h);
            toursGrid.Size = new System.Drawing.Size(w, h);
            countriesGrid.Size = new System.Drawing.Size(w, h);
            bookingsGrid.Size = new System.Drawing.Size(w, h);
            if (bookingsGrid.Columns.Contains("Id")) bookingsGrid.Columns["Id"].Width = 50;
            if (bookingsGrid.Columns.Contains("ClientLastName")) bookingsGrid.Columns["ClientLastName"].Width = 120;
            if (bookingsGrid.Columns.Contains("ClientPhone")) bookingsGrid.Columns["ClientPhone"].Width = 120;
            if (bookingsGrid.Columns.Contains("BookingDate")) bookingsGrid.Columns["BookingDate"].Width = 160;
            if (bookingsGrid.Columns.Contains("Status")) bookingsGrid.Columns["Status"].Width = 100;
            if (bookingsGrid.Columns.Contains("TourName")) bookingsGrid.Columns["TourName"].Width = 180;
            if (bookingsGrid.Columns.Contains("TourDate")) bookingsGrid.Columns["TourDate"].Width = 110;
            if (bookingsGrid.Columns.Contains("TourPrice")) bookingsGrid.Columns["TourPrice"].Width = 100;
            if (bookingsGrid.Columns.Contains("BookingPrice")) bookingsGrid.Columns["BookingPrice"].Width = 110;
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
                foreach (var b in bookings) _bookingService.AddLoaded(b);

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

        private void ToursGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var tour = toursGrid.Rows[e.RowIndex].DataBoundItem as Tour;
            if (tour == null) return;
            new TourDetailsForm(tour).ShowDialog();
        }

        private void AgenciesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var agency = agenciesGrid.Rows[e.RowIndex].DataBoundItem as Agency;
            if (agency == null) return;
            new AgencyDetailsForm(agency, _bookingService).ShowDialog();
        }
        private void BookingsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var booking = bookingsGrid.Rows[e.RowIndex].DataBoundItem as Booking;
            if (booking == null) return;

            var form = new BookingDetailsForm(booking, _bookingService);
            form.ShowDialog();

            if (form.Deleted)
                LoadBookingsToGrid();
        }
        private void SetupNavButtonHover(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                if (btn.BackColor != System.Drawing.Color.FromArgb(52, 73, 120))
                    btn.BackColor = System.Drawing.Color.FromArgb(35, 50, 90);
            };

            btn.MouseLeave += (s, e) =>
            {
                if (btn.BackColor != System.Drawing.Color.FromArgb(52, 73, 120))
                    btn.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            };
        }
        private void BookingsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (bookingsGrid.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Подтверждено")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(210, 245, 220);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 130, 60);
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
                }
                else if (status == "Ожидает")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 210);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 120, 0);
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
                }
                else if (status == "Отменено")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.FromArgb(250, 215, 215);
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 30, 30);
                    e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
                }
            }

        }
        private void CancelBookingButton_Click(object sender, EventArgs e)
        {
            if (bookingsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование!");
                return;
            }

            var booking = bookingsGrid.SelectedRows[0].DataBoundItem as Booking;
            if (booking == null) return;

            if (MessageBox.Show($"Отменить бронь '{booking.ClientLastName}'?",
                "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _bookingService.UpdateStatus(booking.Id, "Отменено");
                LoadBookingsToGrid();
            }
        }
    }

}