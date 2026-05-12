namespace TravelAgency.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenciesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toursMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage agenciesTab;
        private System.Windows.Forms.TabPage toursTab;
        private System.Windows.Forms.TabPage bookingsTab;

        // Агентства
        private System.Windows.Forms.DataGridView agenciesGrid;
        private System.Windows.Forms.Button addAgencyButton;
        private System.Windows.Forms.Button editAgencyButton;
        private System.Windows.Forms.Button deleteAgencyButton;
        private System.Windows.Forms.TextBox searchAgencyBox;
        private System.Windows.Forms.Button searchAgencyButton;
        private System.Windows.Forms.Panel agencyButtonPanel;

        // Туры
        private System.Windows.Forms.DataGridView toursGrid;
        private System.Windows.Forms.Button addTourButton;
        private System.Windows.Forms.Button editTourButton;
        private System.Windows.Forms.Button deleteTourButton;
        private System.Windows.Forms.TextBox searchTourBox;
        private System.Windows.Forms.Button searchTourButton;
        private System.Windows.Forms.Panel tourButtonPanel;

        // Бронирования
        private System.Windows.Forms.DataGridView bookingsGrid;
        private System.Windows.Forms.Button addBookingButton;
        private System.Windows.Forms.Button deleteBookingButton;
        private System.Windows.Forms.Button confirmBookingButton;
        private System.Windows.Forms.Panel bookingButtonPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenciesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toursMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.agenciesTab = new System.Windows.Forms.TabPage();
            this.toursTab = new System.Windows.Forms.TabPage();
            this.bookingsTab = new System.Windows.Forms.TabPage();

            this.agenciesGrid = new System.Windows.Forms.DataGridView();
            this.addAgencyButton = new System.Windows.Forms.Button();
            this.editAgencyButton = new System.Windows.Forms.Button();
            this.deleteAgencyButton = new System.Windows.Forms.Button();
            this.searchAgencyBox = new System.Windows.Forms.TextBox();
            this.searchAgencyButton = new System.Windows.Forms.Button();
            this.agencyButtonPanel = new System.Windows.Forms.Panel();

            this.toursGrid = new System.Windows.Forms.DataGridView();
            this.addTourButton = new System.Windows.Forms.Button();
            this.editTourButton = new System.Windows.Forms.Button();
            this.deleteTourButton = new System.Windows.Forms.Button();
            this.searchTourBox = new System.Windows.Forms.TextBox();
            this.searchTourButton = new System.Windows.Forms.Button();
            this.tourButtonPanel = new System.Windows.Forms.Panel();

            this.bookingsGrid = new System.Windows.Forms.DataGridView();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.deleteBookingButton = new System.Windows.Forms.Button();
            this.confirmBookingButton = new System.Windows.Forms.Button();
            this.bookingButtonPanel = new System.Windows.Forms.Panel();

            // MenuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileMenu,
                this.agenciesMenuItem,
                this.toursMenuItem,
                this.bookingsMenuItem
            });

            this.fileMenu.Text = "Файл";
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.saveMenuItem,
                this.loadMenuItem,
                this.exitMenuItem
            });
            this.saveMenuItem.Text = "Сохранить";
            this.loadMenuItem.Text = "Загрузить";
            this.exitMenuItem.Text = "Выход";

            this.agenciesMenuItem.Text = "Агентства";
            this.toursMenuItem.Text = "Туры";
            this.bookingsMenuItem.Text = "Бронирования";

            // TabControl
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.agenciesTab,
                this.toursTab,
                this.bookingsTab
            });
            this.agenciesTab.Text = "Агентства";
            this.toursTab.Text = "Туры";
            this.bookingsTab.Text = "Бронирования";

            // Панель кнопок агентств
            this.agencyButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.agencyButtonPanel.Height = 40;
            this.addAgencyButton.Text = "Добавить";
            this.addAgencyButton.Width = 90;
            this.addAgencyButton.Location = new System.Drawing.Point(5, 8);
            this.editAgencyButton.Text = "Редактировать";
            this.editAgencyButton.Width = 110;
            this.editAgencyButton.Location = new System.Drawing.Point(100, 8);
            this.deleteAgencyButton.Text = "Удалить";
            this.deleteAgencyButton.Width = 90;
            this.deleteAgencyButton.Location = new System.Drawing.Point(215, 8);
            this.searchAgencyBox.Width = 150;
            this.searchAgencyBox.Location = new System.Drawing.Point(320, 10);
            this.searchAgencyButton.Text = "Поиск";
            this.searchAgencyButton.Width = 70;
            this.searchAgencyButton.Location = new System.Drawing.Point(475, 8);
            this.agencyButtonPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.addAgencyButton, this.editAgencyButton,
                this.deleteAgencyButton, this.searchAgencyBox,
                this.searchAgencyButton
            });
            this.agenciesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenciesGrid.ReadOnly = true;
            this.agenciesGrid.AllowUserToAddRows = false;
            this.agenciesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agenciesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.agenciesTab.Controls.Add(this.agenciesGrid);
            this.agenciesTab.Controls.Add(this.agencyButtonPanel);

            // Панель кнопок туров
            this.tourButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tourButtonPanel.Height = 40;
            this.addTourButton.Text = "Добавить";
            this.addTourButton.Width = 90;
            this.addTourButton.Location = new System.Drawing.Point(5, 8);
            this.editTourButton.Text = "Редактировать";
            this.editTourButton.Width = 110;
            this.editTourButton.Location = new System.Drawing.Point(100, 8);
            this.deleteTourButton.Text = "Удалить";
            this.deleteTourButton.Width = 90;
            this.deleteTourButton.Location = new System.Drawing.Point(215, 8);
            this.searchTourBox.Width = 150;
            this.searchTourBox.Location = new System.Drawing.Point(320, 10);
            this.searchTourButton.Text = "Поиск";
            this.searchTourButton.Width = 70;
            this.searchTourButton.Location = new System.Drawing.Point(475, 8);
            this.tourButtonPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.addTourButton, this.editTourButton,
                this.deleteTourButton, this.searchTourBox,
                this.searchTourButton
            });
            this.toursGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toursGrid.ReadOnly = true;
            this.toursGrid.AllowUserToAddRows = false;
            this.toursGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toursGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toursTab.Controls.Add(this.toursGrid);
            this.toursTab.Controls.Add(this.tourButtonPanel);

            // Панель кнопок бронирований
            this.bookingButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingButtonPanel.Height = 40;
            this.addBookingButton.Text = "Добавить";
            this.addBookingButton.Width = 90;
            this.addBookingButton.Location = new System.Drawing.Point(5, 8);
            this.deleteBookingButton.Text = "Удалить";
            this.deleteBookingButton.Width = 90;
            this.deleteBookingButton.Location = new System.Drawing.Point(100, 8);
            this.confirmBookingButton.Text = "Подтвердить";
            this.confirmBookingButton.Width = 100;
            this.confirmBookingButton.Location = new System.Drawing.Point(195, 8);
            this.bookingButtonPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.addBookingButton,
                this.deleteBookingButton,
                this.confirmBookingButton
            });
            this.bookingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsGrid.ReadOnly = true;
            this.bookingsGrid.AllowUserToAddRows = false;
            this.bookingsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingsTab.Controls.Add(this.bookingsGrid);
            this.bookingsTab.Controls.Add(this.bookingButtonPanel);

            // MainForm
            this.Text = "Турагентство";
            this.Size = new System.Drawing.Size(900, 600);
            this.MainMenuStrip = this.menuStrip;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
        }
    }
}