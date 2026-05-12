namespace TravelAgency.Forms
{
    partial class TourForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.DateTimePicker departurePicker;
        private System.Windows.Forms.Label agencyLabel;
        private System.Windows.Forms.ComboBox agencyComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.departureLabel = new System.Windows.Forms.Label();
            this.departurePicker = new System.Windows.Forms.DateTimePicker();
            this.agencyLabel = new System.Windows.Forms.Label();
            this.agencyComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();

            // Название
            this.nameLabel.Text = "Название:";
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Width = 120;
            this.nameBox.Location = new System.Drawing.Point(140, 12);
            this.nameBox.Width = 220;

            // Описание
            this.descriptionLabel.Text = "Описание:";
            this.descriptionLabel.Location = new System.Drawing.Point(12, 50);
            this.descriptionLabel.Width = 120;
            this.descriptionBox.Location = new System.Drawing.Point(140, 47);
            this.descriptionBox.Width = 220;

            // Цена
            this.priceLabel.Text = "Цена:";
            this.priceLabel.Location = new System.Drawing.Point(12, 85);
            this.priceLabel.Width = 120;
            this.priceBox.Location = new System.Drawing.Point(140, 82);
            this.priceBox.Width = 220;

            // Длительность
            this.durationLabel.Text = "Длительность (дней):";
            this.durationLabel.Location = new System.Drawing.Point(12, 120);
            this.durationLabel.Width = 120;
            this.durationBox.Location = new System.Drawing.Point(140, 117);
            this.durationBox.Width = 220;

            // Дата вылета
            this.departureLabel.Text = "Дата вылета:";
            this.departureLabel.Location = new System.Drawing.Point(12, 155);
            this.departureLabel.Width = 120;
            this.departurePicker.Location = new System.Drawing.Point(140, 152);
            this.departurePicker.Width = 220;

            // Агентство
            this.agencyLabel.Text = "Агентство:";
            this.agencyLabel.Location = new System.Drawing.Point(12, 190);
            this.agencyLabel.Width = 120;
            this.agencyComboBox.Location = new System.Drawing.Point(140, 187);
            this.agencyComboBox.Width = 220;
            this.agencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Страна
            this.countryLabel.Text = "Страна:";
            this.countryLabel.Location = new System.Drawing.Point(12, 225);
            this.countryLabel.Width = 120;
            this.countryComboBox.Location = new System.Drawing.Point(140, 222);
            this.countryComboBox.Width = 220;
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Кнопки
            this.saveButton.Text = "Сохранить";
            this.saveButton.Location = new System.Drawing.Point(140, 265);
            this.saveButton.Width = 100;

            this.cancelButton.Text = "Отмена";
            this.cancelButton.Location = new System.Drawing.Point(260, 265);
            this.cancelButton.Width = 100;

            // Форма
            this.Text = "Тур";
            this.Size = new System.Drawing.Size(400, 340);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.nameLabel, this.nameBox,
                this.descriptionLabel, this.descriptionBox,
                this.priceLabel, this.priceBox,
                this.durationLabel, this.durationBox,
                this.departureLabel, this.departurePicker,
                this.agencyLabel, this.agencyComboBox,
                this.countryLabel, this.countryComboBox,
                this.saveButton, this.cancelButton
            });
        }
    }
}