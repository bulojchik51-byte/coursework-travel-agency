using System.Windows.Forms;
using TravelAgency.Models;

namespace TravelAgency.Forms
{
    public partial class CountryForm : Form
    {
        public Country Country { get; private set; }

        public CountryForm(Country country = null)
        {
            InitializeComponent();

            if (country != null)
            {
                Country = country;
                nameBox.Text = country.Name;
                descriptionBox.Text = country.Description;
                visaCheckBox.Checked = country.VisaRequired;
            }
            else
            {
                Country = new Country();
            }

            saveButton.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show("Введите название страны!");
                    return;
                }
                Country.Name = nameBox.Text.Trim();
                Country.Description = descriptionBox.Text.Trim();
                Country.VisaRequired = visaCheckBox.Checked;
                DialogResult = DialogResult.OK;
            };

            cancelButton.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }
    }
}