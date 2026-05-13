using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelAgency.Models;

namespace TravelAgency.Forms
{
    public partial class BookingForm : Form
    {
        public Booking Booking { get; private set; }

        public BookingForm(List<Tour> tours)
        {
            InitializeComponent();

            tourComboBox.DataSource = tours;
            tourComboBox.DisplayMember = "Name";
            tourComboBox.ValueMember = "Id";

            Booking = new Booking();

            saveButton.Click += SaveButton_Click;
            cancelButton.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientLastNameBox.Text))
            {
                MessageBox.Show("Введите фамилию клиента!");
                return;
            }

            if (string.IsNullOrWhiteSpace(clientPhoneBox.Text))
            {
                MessageBox.Show("Введите телефон клиента!");
                return;
            }

            if (tourComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите тур!");
                return;
            }

            Booking.ClientLastName = clientLastNameBox.Text.Trim();
            Booking.ClientPhone = clientPhoneBox.Text.Trim();
            Booking.Tour = tourComboBox.SelectedItem as Tour;

            DialogResult = DialogResult.OK;
        }
    }
}