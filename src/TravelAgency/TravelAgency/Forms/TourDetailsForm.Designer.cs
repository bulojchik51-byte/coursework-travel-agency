namespace TravelAgency.Forms
{
    partial class TourDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label agencyLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label departureDateLabel;
        private System.Windows.Forms.Label citiesLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button closeButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.agencyLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.departureDateLabel = new System.Windows.Forms.Label();
            this.citiesLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();

            this.nameLabel.Text = "Название тура";
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.nameLabel.Location = new System.Drawing.Point(20, 15);
            this.nameLabel.Size = new System.Drawing.Size(420, 30);

            var separator = new System.Windows.Forms.Panel();
            separator.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            separator.Location = new System.Drawing.Point(20, 50);
            separator.Size = new System.Drawing.Size(420, 2);

            SetupInfoLabel(this.countryLabel, 20, 62);
            SetupInfoLabel(this.agencyLabel, 20, 97);
            SetupInfoLabel(this.priceLabel, 20, 132);
            SetupInfoLabel(this.durationLabel, 20, 167);
            SetupInfoLabel(this.departureDateLabel, 20, 202);
            SetupInfoLabel(this.citiesLabel, 20, 237);

            this.descriptionLabel.Location = new System.Drawing.Point(20, 272);
            this.descriptionLabel.Size = new System.Drawing.Size(420, 60);
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(80, 100, 140);

            this.closeButton.Text = "Закрыть";
            this.closeButton.Location = new System.Drawing.Point(330, 345);
            this.closeButton.Size = new System.Drawing.Size(110, 35);
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10);
            this.closeButton.Click += (s, e) => this.Close();

            this.Text = "Информация о туре";
            this.Size = new System.Drawing.Size(480, 430);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.nameLabel, separator,
                this.countryLabel, this.agencyLabel,
                this.priceLabel, this.durationLabel,
                this.departureDateLabel, this.citiesLabel,
                this.descriptionLabel, this.closeButton
            });
        }

        private void SetupInfoLabel(System.Windows.Forms.Label lbl, int left, int top)
        {
            lbl.Location = new System.Drawing.Point(left, top);
            lbl.Size = new System.Drawing.Size(420, 28);
            lbl.Font = new System.Drawing.Font("Segoe UI", 10);
            lbl.ForeColor = System.Drawing.Color.FromArgb(40, 60, 100);
        }
    }
}