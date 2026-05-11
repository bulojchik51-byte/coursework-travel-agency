namespace TravelAgency.Forms
{
    partial class AgencyForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressBox;
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
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();

            // Название
            this.nameLabel.Text = "Название:";
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Width = 100;

            this.nameBox.Location = new System.Drawing.Point(120, 12);
            this.nameBox.Width = 220;

            // Телефон
            this.phoneLabel.Text = "Телефон:";
            this.phoneLabel.Location = new System.Drawing.Point(12, 50);
            this.phoneLabel.Width = 100;

            this.phoneBox.Location = new System.Drawing.Point(120, 47);
            this.phoneBox.Width = 220;

            // Email
            this.emailLabel.Text = "Email:";
            this.emailLabel.Location = new System.Drawing.Point(12, 85);
            this.emailLabel.Width = 100;

            this.emailBox.Location = new System.Drawing.Point(120, 82);
            this.emailBox.Width = 220;

            // Адрес
            this.addressLabel.Text = "Адрес:";
            this.addressLabel.Location = new System.Drawing.Point(12, 120);
            this.addressLabel.Width = 100;

            this.addressBox.Location = new System.Drawing.Point(120, 117);
            this.addressBox.Width = 220;

            // Кнопки
            this.saveButton.Text = "Сохранить";
            this.saveButton.Location = new System.Drawing.Point(120, 160);
            this.saveButton.Width = 100;

            this.cancelButton.Text = "Отмена";
            this.cancelButton.Location = new System.Drawing.Point(240, 160);
            this.cancelButton.Width = 100;

            // Форма
            this.Text = "Агентство";
            this.Size = new System.Drawing.Size(380, 240);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.nameLabel, this.nameBox,
                this.phoneLabel, this.phoneBox,
                this.emailLabel, this.emailBox,
                this.addressLabel, this.addressBox,
                this.saveButton, this.cancelButton
            });
        }
    }
}