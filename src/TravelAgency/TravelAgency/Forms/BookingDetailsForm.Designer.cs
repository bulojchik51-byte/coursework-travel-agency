namespace TravelAgency.Forms
{
    partial class BookingDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label tourLabel;
        private System.Windows.Forms.Label tourDateLabel;
        private System.Windows.Forms.Label tourPriceLabel;
        private System.Windows.Forms.Label bookingPriceLabel;
        private System.Windows.Forms.Label bookingDateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.tourLabel = new System.Windows.Forms.Label();
            this.tourDateLabel = new System.Windows.Forms.Label();
            this.tourPriceLabel = new System.Windows.Forms.Label();
            this.bookingPriceLabel = new System.Windows.Forms.Label();
            this.bookingDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteButton.Text = "🗑 Удалить";
            this.deleteButton.Location = new System.Drawing.Point(20, 355);
            this.deleteButton.Size = new System.Drawing.Size(110, 35);
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10);
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton = new System.Windows.Forms.Button();

            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Size = new System.Drawing.Size(420, 30);

            var separator = new System.Windows.Forms.Panel();
            separator.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            separator.Location = new System.Drawing.Point(20, 50);
            separator.Size = new System.Drawing.Size(420, 2);

            SetupInfoLabel(this.lastNameLabel, 20, 62);
            SetupInfoLabel(this.phoneLabel, 20, 97);
            SetupInfoLabel(this.tourLabel, 20, 132);
            SetupInfoLabel(this.tourDateLabel, 20, 167);
            SetupInfoLabel(this.tourPriceLabel, 20, 202);
            SetupInfoLabel(this.bookingPriceLabel, 20, 237);
            SetupInfoLabel(this.bookingDateLabel, 20, 272);
            SetupInfoLabel(this.statusLabel, 20, 307);

            this.closeButton.Text = "Закрыть";
            this.closeButton.Location = new System.Drawing.Point(330, 355);
            this.closeButton.Size = new System.Drawing.Size(110, 35);
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10);
            this.closeButton.Click += (s, e) => this.Close();

            this.Text = "Информация о бронировании";
            this.Size = new System.Drawing.Size(480, 440);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.titleLabel, separator,
                this.lastNameLabel, this.phoneLabel,
                this.tourLabel, this.tourDateLabel,
                this.tourPriceLabel, this.bookingPriceLabel,
                this.bookingDateLabel, this.statusLabel,
                this.closeButton, this.deleteButton
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