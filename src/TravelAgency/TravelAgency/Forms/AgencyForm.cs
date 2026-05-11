using System;
using System.Windows.Forms;
using TravelAgency.Models;

namespace TravelAgency.Forms
{
    public partial class AgencyForm : Form
    {
        public Agency Agency { get; private set; }

        public AgencyForm(Agency agency = null)
        {
            InitializeComponent();

            if (agency != null)
            {
                Agency = agency;
                nameBox.Text = agency.Name;
                phoneBox.Text = agency.Phone;
                emailBox.Text = agency.Email;
                addressBox.Text = agency.Address;
            }
            else
            {
                Agency = new Agency();
            }

            saveButton.Click += SaveButton_Click;
            cancelButton.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Введите название агентства!");
                return;
            }

            Agency.Name = nameBox.Text.Trim();
            Agency.Phone = phoneBox.Text.Trim();
            Agency.Email = emailBox.Text.Trim();
            Agency.Address = addressBox.Text.Trim();

            DialogResult = DialogResult.OK;
        }
    }
}