namespace TravelAgency.Forms
{
    partial class CountryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();

            this.nameLabel.Text = "Название:";
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Width = 100;
            this.nameBox.Location = new System.Drawing.Point(120, 12);
            this.nameBox.Width = 220;

            this.descriptionLabel.Text = "Описание:";
            this.descriptionLabel.Location = new System.Drawing.Point(12, 50);
            this.descriptionLabel.Width = 100;
            this.descriptionBox.Location = new System.Drawing.Point(120, 47);
            this.descriptionBox.Width = 220;

            this.saveButton.Text = "Сохранить";
            this.saveButton.Location = new System.Drawing.Point(120, 90);
            this.saveButton.Width = 100;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Location = new System.Drawing.Point(240, 90);
            this.cancelButton.Width = 100;

            this.Text = "Страна";
            this.Size = new System.Drawing.Size(380, 170);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.nameLabel, this.nameBox,
                this.descriptionLabel, this.descriptionBox,
                this.saveButton, this.cancelButton
            });
        }
    }
}