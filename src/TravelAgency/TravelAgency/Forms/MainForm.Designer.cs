namespace TravelAgency.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;

        private System.Windows.Forms.Button navHomeButton;
        private System.Windows.Forms.Button navAgenciesButton;
        private System.Windows.Forms.Button navToursButton;
        private System.Windows.Forms.Button navCountriesButton;
        private System.Windows.Forms.Button navBookingsButton;
        private System.Windows.Forms.Button cancelBookingButton;

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel agenciesPanel;
        private System.Windows.Forms.Panel toursPanel;
        private System.Windows.Forms.Panel countriesPanel;
        private System.Windows.Forms.Panel bookingsPanel;

        private System.Windows.Forms.Label homeTitleLabel;
        private System.Windows.Forms.Label homeSubtitleLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label agenciesCountLabel;
        private System.Windows.Forms.Label toursCountLabel;
        private System.Windows.Forms.Label bookingsCountLabel;
        private System.Windows.Forms.Label countriesCountLabel;

        private System.Windows.Forms.DataGridView agenciesGrid;
        private System.Windows.Forms.Button addAgencyButton;
        private System.Windows.Forms.Button editAgencyButton;
        private System.Windows.Forms.Button deleteAgencyButton;
        private System.Windows.Forms.TextBox searchAgencyBox;
        private System.Windows.Forms.Button searchAgencyButton;
        private System.Windows.Forms.Label agenciesTitleLabel;

        private System.Windows.Forms.DataGridView toursGrid;
        private System.Windows.Forms.Button addTourButton;
        private System.Windows.Forms.Button editTourButton;
        private System.Windows.Forms.Button deleteTourButton;
        private System.Windows.Forms.TextBox searchTourBox;
        private System.Windows.Forms.Button searchTourButton;
        private System.Windows.Forms.Label toursTitleLabel;

        private System.Windows.Forms.DataGridView countriesGrid;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.Button editCountryButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Label countriesTitleLabel;

        private System.Windows.Forms.DataGridView bookingsGrid;
        private System.Windows.Forms.Button addBookingButton;
        private System.Windows.Forms.Button deleteBookingButton;
        private System.Windows.Forms.Button confirmBookingButton;
        private System.Windows.Forms.Label bookingsTitleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();

            this.navHomeButton = new System.Windows.Forms.Button();
            this.navAgenciesButton = new System.Windows.Forms.Button();
            this.navToursButton = new System.Windows.Forms.Button();
            this.navCountriesButton = new System.Windows.Forms.Button();
            this.navBookingsButton = new System.Windows.Forms.Button();

            this.homePanel = new System.Windows.Forms.Panel();
            this.agenciesPanel = new System.Windows.Forms.Panel();
            this.toursPanel = new System.Windows.Forms.Panel();
            this.countriesPanel = new System.Windows.Forms.Panel();
            this.bookingsPanel = new System.Windows.Forms.Panel();

            this.homeTitleLabel = new System.Windows.Forms.Label();
            this.homeSubtitleLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.agenciesCountLabel = new System.Windows.Forms.Label();
            this.toursCountLabel = new System.Windows.Forms.Label();
            this.bookingsCountLabel = new System.Windows.Forms.Label();
            this.countriesCountLabel = new System.Windows.Forms.Label();

            this.agenciesTitleLabel = new System.Windows.Forms.Label();
            this.agenciesGrid = new System.Windows.Forms.DataGridView();
            this.addAgencyButton = new System.Windows.Forms.Button();
            this.editAgencyButton = new System.Windows.Forms.Button();
            this.deleteAgencyButton = new System.Windows.Forms.Button();
            this.searchAgencyBox = new System.Windows.Forms.TextBox();
            this.searchAgencyButton = new System.Windows.Forms.Button();

            this.toursTitleLabel = new System.Windows.Forms.Label();
            this.toursGrid = new System.Windows.Forms.DataGridView();
            this.addTourButton = new System.Windows.Forms.Button();
            this.editTourButton = new System.Windows.Forms.Button();
            this.deleteTourButton = new System.Windows.Forms.Button();
            this.searchTourBox = new System.Windows.Forms.TextBox();
            this.searchTourButton = new System.Windows.Forms.Button();

            this.countriesTitleLabel = new System.Windows.Forms.Label();
            this.countriesGrid = new System.Windows.Forms.DataGridView();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.editCountryButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();

            this.bookingsTitleLabel = new System.Windows.Forms.Label();
            this.bookingsGrid = new System.Windows.Forms.DataGridView();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.deleteBookingButton = new System.Windows.Forms.Button();
            this.confirmBookingButton = new System.Windows.Forms.Button();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            SetupActionButton(this.cancelBookingButton, "✕ Отменить", 450, 75);

            // ═══════════════════════════════
            // БОКОВАЯ ПАНЕЛЬ
            // ═══════════════════════════════
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Width = 220;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);

            // Логотип/заголовок
            this.titleLabel.Text = "✈ TravelAgency";
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(0, 25);
            this.titleLabel.Size = new System.Drawing.Size(220, 35);
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.subtitleLabel.Text = "Система управления турами";
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(120, 144, 190);
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 8);
            this.subtitleLabel.Location = new System.Drawing.Point(0, 58);
            this.subtitleLabel.Size = new System.Drawing.Size(220, 20);
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Разделитель
            var separator = new System.Windows.Forms.Panel();
            separator.BackColor = System.Drawing.Color.FromArgb(40, 55, 90);
            separator.Location = new System.Drawing.Point(20, 85);
            separator.Size = new System.Drawing.Size(180, 1);

            SetupNavButton(this.navHomeButton, "🏠   Главная", 100);
            SetupNavButton(this.navAgenciesButton, "🏢   Агентства", 150);
            SetupNavButton(this.navToursButton, "✈   Туры", 200);
            SetupNavButton(this.navCountriesButton, "🌍   Страны", 250);
            SetupNavButton(this.navBookingsButton, "📋   Бронирования", 300);

            this.sidePanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.titleLabel, this.subtitleLabel, separator,
                this.navHomeButton, this.navAgenciesButton,
                this.navToursButton, this.navCountriesButton,
                this.navBookingsButton
            });

            // ═══════════════════════════════
            // ОСНОВНАЯ ПАНЕЛЬ
            // ═══════════════════════════════
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 25, 30, 20);

            // ═══════════════════════════════
            // ГЛАВНАЯ СТРАНИЦА
            // ═══════════════════════════════
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // Верхний баннер
            var bannerPanel = new System.Windows.Forms.Panel();
            bannerPanel.Location = new System.Drawing.Point(30, 25);
            bannerPanel.Size = new System.Drawing.Size(900, 110);
            bannerPanel.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);

            var bannerTitle = new System.Windows.Forms.Label();
            bannerTitle.Text = "✈ Добро пожаловать в TravelAgency";
            bannerTitle.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            bannerTitle.ForeColor = System.Drawing.Color.White;
            bannerTitle.Location = new System.Drawing.Point(25, 18);
            bannerTitle.Size = new System.Drawing.Size(650, 40);

            var bannerSubtitle = new System.Windows.Forms.Label();
            bannerSubtitle.Text = "Управляйте турами, агентствами и бронированиями в одном месте";
            bannerSubtitle.Font = new System.Drawing.Font("Segoe UI", 10);
            bannerSubtitle.ForeColor = System.Drawing.Color.FromArgb(150, 175, 220);
            bannerSubtitle.Location = new System.Drawing.Point(25, 62);
            bannerSubtitle.Size = new System.Drawing.Size(650, 25);

            bannerPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
    bannerTitle, bannerSubtitle
});

            // Карточки статистики
            SetupStatCard(this.agenciesCountLabel, "🏢", "Агентства", "0", 30, 160);
            SetupStatCard(this.toursCountLabel, "✈", "Туры", "0", 235, 160);
            SetupStatCard(this.bookingsCountLabel, "📋", "Бронирования", "0", 440, 160);
            SetupStatCard(this.countriesCountLabel, "🌍", "Страны", "0", 645, 160);

            // Нижняя информационная панель
            var infoPanel = new System.Windows.Forms.Panel();
            infoPanel.Location = new System.Drawing.Point(30, 310);
            infoPanel.Size = new System.Drawing.Size(900, 80);
            infoPanel.BackColor = System.Drawing.Color.White;

            var infoLabel = new System.Windows.Forms.Label();
            infoLabel.Text = "💡  Используйте боковое меню для навигации между разделами";
            infoLabel.Font = new System.Drawing.Font("Segoe UI", 11);
            infoLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 160);
            infoLabel.Location = new System.Drawing.Point(20, 0);
            infoLabel.Size = new System.Drawing.Size(860, 80);
            infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            infoPanel.Controls.Add(infoLabel);

            this.homePanel.Controls.AddRange(new System.Windows.Forms.Control[] {
    bannerPanel,
    this.agenciesCountLabel,
    this.toursCountLabel,
    this.bookingsCountLabel,
    this.countriesCountLabel,
    infoPanel
});

            // ═══════════════════════════════
            // АГЕНТСТВА
            // ═══════════════════════════════
            this.agenciesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenciesPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.agenciesPanel.Visible = false;

            this.agenciesTitleLabel.Text = "Агентства";
            SetupPageTitle(this.agenciesTitleLabel, 30, 25);

            SetupActionButton(this.addAgencyButton, "+ Добавить", 30, 75);
            SetupActionButton(this.editAgencyButton, "✎ Изменить", 170, 75);
            SetupActionButton(this.deleteAgencyButton, "✕ Удалить", 310, 75);

            this.searchAgencyBox.Location = new System.Drawing.Point(470, 79);
            this.searchAgencyBox.Size = new System.Drawing.Size(220, 32);
            this.searchAgencyBox.Font = new System.Drawing.Font("Segoe UI", 10);
            this.searchAgencyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            SetupActionButton(this.searchAgencyButton, "🔍 Поиск", 698, 75);

            this.agenciesGrid.Location = new System.Drawing.Point(30, 125);
            this.agenciesGrid.Size = new System.Drawing.Size(900, 500);
            SetupGrid(this.agenciesGrid);

            this.agenciesPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.agenciesTitleLabel,
                this.addAgencyButton, this.editAgencyButton,
                this.deleteAgencyButton, this.searchAgencyBox,
                this.searchAgencyButton, this.agenciesGrid
            });

            // ═══════════════════════════════
            // ТУРЫ
            // ═══════════════════════════════
            this.toursPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toursPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.toursPanel.Visible = false;

            this.toursTitleLabel.Text = "Туры";
            SetupPageTitle(this.toursTitleLabel, 30, 25);

            SetupActionButton(this.addTourButton, "+ Добавить", 30, 75);
            SetupActionButton(this.editTourButton, "✎ Изменить", 170, 75);
            SetupActionButton(this.deleteTourButton, "✕ Удалить", 310, 75);

            this.searchTourBox.Location = new System.Drawing.Point(470, 79);
            this.searchTourBox.Size = new System.Drawing.Size(220, 32);
            this.searchTourBox.Font = new System.Drawing.Font("Segoe UI", 10);
            this.searchTourBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            SetupActionButton(this.searchTourButton, "🔍 Поиск", 698, 75);

            this.toursGrid.Location = new System.Drawing.Point(30, 125);
            this.toursGrid.Size = new System.Drawing.Size(900, 500);
            SetupGrid(this.toursGrid);

            this.toursPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.toursTitleLabel,
                this.addTourButton, this.editTourButton,
                this.deleteTourButton, this.searchTourBox,
                this.searchTourButton, this.toursGrid
            });

            // ═══════════════════════════════
            // СТРАНЫ
            // ═══════════════════════════════
            this.countriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.countriesPanel.Visible = false;

            this.countriesTitleLabel.Text = "Страны";
            SetupPageTitle(this.countriesTitleLabel, 30, 25);

            SetupActionButton(this.addCountryButton, "+ Добавить", 30, 75);
            SetupActionButton(this.editCountryButton, "✎ Изменить", 170, 75);
            SetupActionButton(this.deleteCountryButton, "✕ Удалить", 310, 75);

            this.countriesGrid.Location = new System.Drawing.Point(30, 125);
            this.countriesGrid.Size = new System.Drawing.Size(900, 500);
            SetupGrid(this.countriesGrid);

            this.countriesPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.countriesTitleLabel,
                this.addCountryButton, this.editCountryButton,
                this.deleteCountryButton, this.countriesGrid
            });

            // ═══════════════════════════════
            // БРОНИРОВАНИЯ
            // ═══════════════════════════════
            this.bookingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.bookingsPanel.Visible = false;

            this.bookingsTitleLabel.Text = "Бронирования";
            SetupPageTitle(this.bookingsTitleLabel, 30, 25);

            SetupActionButton(this.addBookingButton, "+ Добавить", 30, 75);
            SetupActionButton(this.confirmBookingButton, "✔ Подтвердить", 170, 75);
            SetupActionButton(this.cancelBookingButton, "✕ Отменить", 310, 75);

            this.bookingsGrid.Location = new System.Drawing.Point(30, 125);
            this.bookingsGrid.Size = new System.Drawing.Size(900, 500);
            SetupGrid(this.bookingsGrid);

            this.bookingsPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.cancelBookingButton,
                this.bookingsTitleLabel,
                this.addBookingButton, 
                this.confirmBookingButton, this.bookingsGrid
            });

            // Добавляем панели в mainPanel
            this.mainPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.homePanel, this.agenciesPanel,
                this.toursPanel, this.countriesPanel,
                this.bookingsPanel
            });

            // MainForm
            this.Text = "TravelAgency";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
        }

        private void SetupNavButton(System.Windows.Forms.Button btn, string text, int top)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(0, top);
            btn.Size = new System.Drawing.Size(220, 46);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = System.Drawing.Color.FromArgb(150, 175, 220);
            btn.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            btn.Font = new System.Drawing.Font("Segoe UI", 10);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void SetupActionButton(System.Windows.Forms.Button btn, string text, int left, int top)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left, top);
            btn.Size = new System.Drawing.Size(130, 38);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Segoe UI", 10);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void SetupPageTitle(System.Windows.Forms.Label lbl, int left, int top)
        {
            lbl.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(22, 33, 62);
            lbl.Location = new System.Drawing.Point(left, top);
            lbl.Size = new System.Drawing.Size(400, 40);
        }

        private void SetupGrid(System.Windows.Forms.DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = System.Drawing.Color.White;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.RowHeadersVisible = false;
            grid.Font = new System.Drawing.Font("Segoe UI", 10);
            grid.RowTemplate.Height = 38;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 62);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            grid.EnableHeadersVisualStyles = false;
            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            grid.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = System.Drawing.Color.FromArgb(230, 235, 245);
        }

        private void SetupStatCard(System.Windows.Forms.Label lbl, string icon, string title, string count, int left, int top)
        {
            lbl.Text = $"{icon}\n{title}\n{count}";
            lbl.Location = new System.Drawing.Point(left, top);
            lbl.Size = new System.Drawing.Size(185, 130);
            lbl.BackColor = System.Drawing.Color.White;
            lbl.ForeColor = System.Drawing.Color.FromArgb(22, 33, 62);
            lbl.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbl.Padding = new System.Windows.Forms.Padding(5);
            lbl.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}