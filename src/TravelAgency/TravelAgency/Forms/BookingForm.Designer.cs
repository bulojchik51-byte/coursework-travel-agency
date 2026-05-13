namespace TravelAgency.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label clientLastNameLabel;
        private System.Windows.Forms.TextBox clientLastNameBox;
        private System.Windows.Forms.Label clientPhoneLabel;
        private System.Windows.Forms.TextBox clientPhoneBox;
        private System.Windows.Forms.Label tourLabel;
        private System.Windows.Forms.ComboBox tourComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.clientLastNameLabel = new System.Windows.Forms.Label();
            this.clientLastNameBox = new System.Windows.Forms.TextBox();
            this.clientPhoneLabel = new System.Windows.Forms.Label();
            this.clientPhoneBox = new System.Windows.Forms.TextBox();
            this.tourLabel = new System.Windows.Forms.Label();
            this.tourComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();

            this.clientLastNameLabel.Text = "Фамилия клиента:";
            this.clientLastNameLabel.Location = new System.Drawing.Point(12, 15);
            this.clientLastNameLabel.Width = 130;

            this.clientLastNameBox.Location = new System.Drawing.Point(150, 12);
            this.clientLastNameBox.Width = 220;

            this.clientPhoneLabel.Text = "Телефон:";
            this.clientPhoneLabel.Location = new System.Drawing.Point(12, 50);
            this.clientPhoneLabel.Width = 130;

            this.clientPhoneBox.Location = new System.Drawing.Point(150, 47);
            this.clientPhoneBox.Width = 220;

            this.tourLabel.Text = "Тур:";
            this.tourLabel.Location = new System.Drawing.Point(12, 85);
            this.tourLabel.Width = 130;

            this.tourComboBox.Location = new System.Drawing.Point(150, 82);
            this.tourComboBox.Width = 220;
            this.tourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.saveButton.Text = "Сохранить";
            this.saveButton.Location = new System.Drawing.Point(150, 125);
            this.saveButton.Width = 100;

            this.cancelButton.Text = "Отмена";
            this.cancelButton.Location = new System.Drawing.Point(270, 125);
            this.cancelButton.Width = 100;

            this.Text = "Новое бронирование";
            this.Size = new System.Drawing.Size(420, 210);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.clientLastNameLabel, this.clientLastNameBox,
                this.clientPhoneLabel, this.clientPhoneBox,
                this.tourLabel, this.tourComboBox,
                this.saveButton, this.cancelButton
            });
        }
    }
}