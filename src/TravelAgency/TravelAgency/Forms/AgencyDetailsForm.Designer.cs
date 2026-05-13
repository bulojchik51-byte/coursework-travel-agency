namespace TravelAgency.Forms
{
    partial class AgencyDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label bookingsLabel;
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
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.bookingsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();

            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.nameLabel.Location = new System.Drawing.Point(20, 15);
            this.nameLabel.Size = new System.Drawing.Size(420, 30);

            var separator = new System.Windows.Forms.Panel();
            separator.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            separator.Location = new System.Drawing.Point(20, 50);
            separator.Size = new System.Drawing.Size(420, 2);

            SetupInfoLabel(this.phoneLabel, 20, 62);
            SetupInfoLabel(this.emailLabel, 20, 97);
            SetupInfoLabel(this.addressLabel, 20, 132);

            this.bookingsLabel.Location = new System.Drawing.Point(20, 175);
            this.bookingsLabel.Size = new System.Drawing.Size(420, 35);
            this.bookingsLabel.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.bookingsLabel.ForeColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.bookingsLabel.BackColor = System.Drawing.Color.FromArgb(230, 240, 255);

            this.closeButton.Text = "Закрыть";
            this.closeButton.Location = new System.Drawing.Point(330, 230);
            this.closeButton.Size = new System.Drawing.Size(110, 35);
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10);
            this.closeButton.Click += (s, e) => this.Close();

            this.Text = "Информация об агентстве";
            this.Size = new System.Drawing.Size(480, 320);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.nameLabel, separator,
                this.phoneLabel, this.emailLabel,
                this.addressLabel, this.bookingsLabel,
                this.closeButton
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