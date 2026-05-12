namespace TravelAgency.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientNameBox;
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
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNameBox = new System.Windows.Forms.TextBox();
            this.clientPhoneLabel = new System.Windows.Forms.Label();
            this.clientPhoneBox = new System.Windows.Forms.TextBox();
            this.tourLabel = new System.Windows.Forms.Label();
            this.tourComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();

            // Имя клиента
            this.clientNameLabel.Text = "Имя клиента:";
            this.clientNameLabel.Location = new System.Drawing.Point(12, 15);
            this.clientNameLabel.Width = 120;
            this.clientNameBox.Location = new System.Drawing.Point(140, 12);
            this.clientNameBox.Width = 220;

            // Телефон клиента
            this.clientPhoneLabel.Text = "Телефон:";
            this.clientPhoneLabel.Location = new System.Drawing.Point(12, 50);
            this.clientPhoneLabel.Width = 120;
            this.clientPhoneBox.Location = new System.Drawing.Point(140, 47);
            this.clientPhoneBox.Width = 220;

            // Тур
            this.tourLabel.Text = "Тур:";
            this.tourLabel.Location = new System.Drawing.Point(12, 85);
            this.tourLabel.Width = 120;
            this.tourComboBox.Location = new System.Drawing.Point(140, 82);
            this.tourComboBox.Width = 220;
            this.tourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Кнопки
            this.saveButton.Text = "Сохранить";
            this.saveButton.Location = new System.Drawing.Point(140, 125);
            this.saveButton.Width = 100;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Location = new System.Drawing.Point(260, 125);
            this.cancelButton.Width = 100;

            // Форма
            this.Text = "Новое бронирование";
            this.Size = new System.Drawing.Size(400, 210);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.clientNameLabel, this.clientNameBox,
                this.clientPhoneLabel, this.clientPhoneBox,
                this.tourLabel, this.tourComboBox,
                this.saveButton, this.cancelButton
            });
        }
    }
}