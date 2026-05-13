using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelAgency.Models;

namespace TravelAgency.Forms
{
    public partial class TourForm : Form
    {
        public Tour Tour { get; private set; }

        public TourForm(List<Agency> agencies, List<Country> countries, Tour tour = null)
        {
            InitializeComponent();

            agencyComboBox.DataSource = agencies;
            agencyComboBox.DisplayMember = "Name";
            agencyComboBox.ValueMember = "Id";

            countryComboBox.DataSource = countries;
            countryComboBox.DisplayMember = "Name";
            countryComboBox.ValueMember = "Id";

            if (tour != null)
            {
                Tour = tour;
                citiesBox.Text = tour.Cities;
                nameBox.Text = tour.Name;
                descriptionBox.Text = tour.Description;
                priceBox.Text = tour.Price.ToString();
                durationBox.Text = tour.DurationDays.ToString();
                departurePicker.Value = tour.DepartureDate;

                if (tour.Agency != null)
                    agencyComboBox.SelectedValue = tour.Agency.Id;
                if (tour.Country != null)
                    countryComboBox.SelectedValue = tour.Country.Id;
            }
            else
            {
                Tour = new Tour();
            }

            saveButton.Click += SaveButton_Click;
            cancelButton.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Введите название тура!");
                return;
            }

            if (!decimal.TryParse(priceBox.Text, out decimal price))
            {
                MessageBox.Show("Введите корректную цену!");
                return;
            }

            if (!int.TryParse(durationBox.Text, out int duration))
            {
                MessageBox.Show("Введите корректную продолжительность!");
                return;
            }

            Tour.Name = nameBox.Text.Trim();
            Tour.Description = descriptionBox.Text.Trim();
            Tour.Price = price;
            Tour.DurationDays = duration;
            Tour.DepartureDate = departurePicker.Value;
            Tour.Agency = agencyComboBox.SelectedItem as Agency;
            Tour.Country = countryComboBox.SelectedItem as Country;
            Tour.Cities = citiesBox.Text.Trim();

            DialogResult = DialogResult.OK;
        }

    }
}