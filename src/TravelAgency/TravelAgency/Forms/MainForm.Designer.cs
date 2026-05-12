namespace TravelAgency.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Основные панели
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;

        // Заголовок
        private System.Windows.Forms.Label titleLabel;

        // Кнопки навигации
        private System.Windows.Forms.Button navHomeButton;
        private System.Windows.Forms.Button navAgenciesButton;
        private System.Windows.Forms.Button navToursButton;
        private System.Windows.Forms.Button navCountriesButton;
        private System.Windows.Forms.Button navBookingsButton;

        // Панели контента
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel agenciesPanel;
        private System.Windows.Forms.Panel toursPanel;
        private System.Windows.Forms.Panel countriesPanel;
        private System.Windows.Forms.Panel bookingsPanel;

        // Главная страница
        private System.Windows.Forms.Label homeTitleLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label agenciesCountLabel;
        private System.Windows.Forms.Label toursCountLabel;
        private System.Windows.Forms.Label bookingsCountLabel;
        private System.Windows.Forms.Label countriesCountLabel;

        // Агентства
        private System.Windows.Forms.DataGridView agenciesGrid;
        private System.Windows.Forms.Button addAgencyButton;
        private System.Windows.Forms.Button editAgencyButton;
        private System.Windows.Forms.Button deleteAgencyButton;
        private System.Windows.Forms.TextBox searchAgencyBox;
        private System.Windows.Forms.Button searchAgencyButton;
        private System.Windows.Forms.Label agenciesTitleLabel;

        // Туры
        private System.Windows.Forms.DataGridView toursGrid;
        private System.Windows.Forms.Button addTourButton;
        private System.Windows.Forms.Button editTourButton;
        private System.Windows.Forms.Button deleteTourButton;
        private System.Windows.Forms.TextBox searchTourBox;
        private System.Windows.Forms.Button searchTourButton;
        private System.Windows.Forms.Label toursTitleLabel;

        // Страны
        private System.Windows.Forms.DataGridView countriesGrid;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.Button editCountryButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Label countriesTitleLabel;

        // Бронирования
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
            // Панели
            this.sidePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();

            // Кнопки навигации
            this.navHomeButton = new System.Windows.Forms.Button();
            this.navAgenciesButton = new System.Windows.Forms.Button();
            this.navToursButton = new System.Windows.Forms.Button();
            this.navCountriesButton = new System.Windows.Forms.Button();
            this.navBookingsButton = new System.Windows.Forms.Button();

            // Панели контента
            this.homePanel = new System.Windows.Forms.Panel();
            this.agenciesPanel = new System.Windows.Forms.Panel();
            this.toursPanel = new System.Windows.Forms.Panel();
            this.countriesPanel = new System.Windows.Forms.Panel();
            this.bookingsPanel = new System.Windows.Forms.Panel();

            // Главная
            this.homeTitleLabel = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.agenciesCountLabel = new System.Windows.Forms.Label();
            this.toursCountLabel = new System.Windows.Forms.Label();
            this.bookingsCountLabel = new System.Windows.Forms.Label();
            this.countriesCountLabel = new System.Windows.Forms.Label();

            // Агентства
            this.agenciesTitleLabel = new System.Windows.Forms.Label();
            this.agenciesGrid = new System.Windows.Forms.DataGridView();
            this.addAgencyButton = new System.Windows.Forms.Button();
            this.editAgencyButton = new System.Windows.Forms.Button();
            this.deleteAgencyButton = new System.Windows.Forms.Button();
            this.searchAgencyBox = new System.Windows.Forms.TextBox();
            this.searchAgencyButton = new System.Windows.Forms.Button();

            // Туры
            this.toursTitleLabel = new System.Windows.Forms.Label();
            this.toursGrid = new System.Windows.Forms.DataGridView();
            this.addTourButton = new System.Windows.Forms.Button();
            this.editTourButton = new System.Windows.Forms.Button();
            this.deleteTourButton = new System.Windows.Forms.Button();
            this.searchTourBox = new System.Windows.Forms.TextBox();
            this.searchTourButton = new System.Windows.Forms.Button();
            
            // Страны
            this.countriesTitleLabel = new System.Windows.Forms.Label();
            this.countriesGrid = new System.Windows.Forms.DataGridView();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.editCountryButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();

            // Бронирования
            this.bookingsTitleLabel = new System.Windows.Forms.Label();
            this.bookingsGrid = new System.Windows.Forms.DataGridView();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.deleteBookingButton = new System.Windows.Forms.Button();
            this.confirmBookingButton = new System.Windows.Forms.Button();

            // ═══════════════════════════════
            // БОКОВАЯ ПАНЕЛЬ
            // ═══════════════════════════════
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Width = 200;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(31, 43, 71);

            // Заголовок в боковой панели
            this.titleLabel.Text = "✈ Турагентство";
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(10, 20);
            this.titleLabel.Size = new System.Drawing.Size(180, 40);
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Кнопки навигации
            SetupNavButton(this.navHomeButton, "🏠  Главная", 80);
            SetupNavButton(this.navAgenciesButton, "🏢  Агентства", 130);
            SetupNavButton(this.navToursButton, "✈  Туры", 180);
            SetupNavButton(this.navCountriesButton, "🌍  Страны", 230);
            SetupNavButton(this.navBookingsButton, "📋  Бронирования", 280);

            this.sidePanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.titleLabel,
                this.navHomeButton,
                this.navAgenciesButton,
                this.navToursButton,
                this.navCountriesButton,
                this.navBookingsButton
            });

            // ═══════════════════════════════
            // ОСНОВНАЯ ПАНЕЛЬ
            // ═══════════════════════════════
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // ═══════════════════════════════
            // ПАНЕЛЬ ГЛАВНАЯ
            // ═══════════════════════════════
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.homeTitleLabel.Text = "Добро пожаловать!";
            this.homeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.homeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 43, 71);
            this.homeTitleLabel.Location = new System.Drawing.Point(30, 30);
            this.homeTitleLabel.Size = new System.Drawing.Size(400, 40);

            // Карточки статистики
            SetupStatCard(this.agenciesCountLabel, "🏢 Агентств: 0", 30, 100);
            SetupStatCard(this.toursCountLabel, "✈ Туров: 0", 200, 100);
            SetupStatCard(this.bookingsCountLabel, "📋 Броней: 0", 370, 100);
            SetupStatCard(this.countriesCountLabel, "🌍 Стран: 0", 540, 100);

            this.homePanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.homeTitleLabel,
                this.agenciesCountLabel,
                this.toursCountLabel,
                this.bookingsCountLabel,
                this.countriesCountLabel
            });

            // ═══════════════════════════════
            // ПАНЕЛЬ АГЕНТСТВА
            // ═══════════════════════════════
            this.agenciesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenciesPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.agenciesPanel.Visible = false;

            this.agenciesTitleLabel.Text = "🏢 Агентства";
            this.agenciesTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.agenciesTitleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 43, 71);
            this.agenciesTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.agenciesTitleLabel.Size = new System.Drawing.Size(300, 35);

            SetupActionButton(this.addAgencyButton, "＋ Добавить", 20, 65);
            SetupActionButton(this.editAgencyButton, "✎ Редактировать", 120, 65);
            SetupActionButton(this.deleteAgencyButton, "✕ Удалить", 250, 65);

            this.searchAgencyBox.Location = new System.Drawing.Point(370, 67);
            this.searchAgencyBox.Size = new System.Drawing.Size(180, 28);
            this.searchAgencyBox.Font = new System.Drawing.Font("Segoe UI", 10);

            SetupActionButton(this.searchAgencyButton, "🔍 Поиск", 555, 65);

            this.agenciesGrid.Location = new System.Drawing.Point(20, 105);
            this.agenciesGrid.Size = new System.Drawing.Size(840, 420);
            SetupGrid(this.agenciesGrid);

            this.agenciesPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.agenciesTitleLabel,
                this.addAgencyButton, this.editAgencyButton,
                this.deleteAgencyButton, this.searchAgencyBox,
                this.searchAgencyButton, this.agenciesGrid
            });

            // ═══════════════════════════════
            // ПАНЕЛЬ ТУРЫ
            // ═══════════════════════════════
            this.toursPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toursPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.toursPanel.Visible = false;

            this.toursTitleLabel.Text = "✈ Туры";
            this.toursTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.toursTitleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 43, 71);
            this.toursTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.toursTitleLabel.Size = new System.Drawing.Size(300, 35);

            SetupActionButton(this.addTourButton, "＋ Добавить", 20, 65);
            SetupActionButton(this.editTourButton, "✎ Редактировать", 120, 65);
            SetupActionButton(this.deleteTourButton, "✕ Удалить", 250, 65);

            this.searchTourBox.Location = new System.Drawing.Point(370, 67);
            this.searchTourBox.Size = new System.Drawing.Size(180, 28);
            this.searchTourBox.Font = new System.Drawing.Font("Segoe UI", 10);

            SetupActionButton(this.searchTourButton, "🔍 Поиск", 555, 65);
            

            this.toursGrid.Location = new System.Drawing.Point(20, 105);
            this.toursGrid.Size = new System.Drawing.Size(840, 420);
            SetupGrid(this.toursGrid);

            this.toursPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.toursTitleLabel,
                this.addTourButton, this.editTourButton,
                this.deleteTourButton, this.searchTourBox,
                this.searchTourButton, this.toursGrid

            });

            // ═══════════════════════════════
            // ПАНЕЛЬ СТРАНЫ
            // ═══════════════════════════════
            this.countriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.countriesPanel.Visible = false;

            this.countriesTitleLabel.Text = "🌍 Страны";
            this.countriesTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.countriesTitleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 43, 71);
            this.countriesTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.countriesTitleLabel.Size = new System.Drawing.Size(300, 35);

            SetupActionButton(this.addCountryButton, "＋ Добавить", 20, 65);
            SetupActionButton(this.editCountryButton, "✎ Редактировать", 120, 65);
            SetupActionButton(this.deleteCountryButton, "✕ Удалить", 250, 65);

            this.countriesGrid.Location = new System.Drawing.Point(20, 105);
            this.countriesGrid.Size = new System.Drawing.Size(840, 420);
            SetupGrid(this.countriesGrid);

            this.countriesPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.countriesTitleLabel,
                this.addCountryButton, this.editCountryButton,
                this.deleteCountryButton, this.countriesGrid
            });

            // ═══════════════════════════════
            // ПАНЕЛЬ БРОНИРОВАНИЯ
            // ═══════════════════════════════
            this.bookingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.bookingsPanel.Visible = false;

            this.bookingsTitleLabel.Text = "📋 Бронирования";
            this.bookingsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.bookingsTitleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 43, 71);
            this.bookingsTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.bookingsTitleLabel.Size = new System.Drawing.Size(300, 35);

            SetupActionButton(this.addBookingButton, "＋ Добавить", 20, 65);
            SetupActionButton(this.deleteBookingButton, "✕ Удалить", 120, 65);
            SetupActionButton(this.confirmBookingButton, "✔ Подтвердить", 220, 65);

            this.bookingsGrid.Location = new System.Drawing.Point(20, 105);
            this.bookingsGrid.Size = new System.Drawing.Size(840, 420);
            SetupGrid(this.bookingsGrid);

            this.bookingsPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.bookingsTitleLabel,
                this.addBookingButton, this.deleteBookingButton,
                this.confirmBookingButton, this.bookingsGrid
            });

            // Добавляем панели в mainPanel
            this.mainPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.homePanel,
                this.agenciesPanel,
                this.toursPanel,
                this.countriesPanel,
                this.bookingsPanel
            });

            // MainForm
            this.Text = "Турагентство";
            this.Size = new System.Drawing.Size(1100, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
        }

        private void SetupNavButton(System.Windows.Forms.Button btn, string text, int top)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(0, top);
            btn.Size = new System.Drawing.Size(200, 45);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
            btn.BackColor = System.Drawing.Color.FromArgb(31, 43, 71);
            btn.Font = new System.Drawing.Font("Segoe UI", 10);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void SetupActionButton(System.Windows.Forms.Button btn, string text, int left, int top)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left, top);
            btn.Size = new System.Drawing.Size(110, 32);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = System.Drawing.Color.FromArgb(31, 43, 71);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Segoe UI", 9);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            grid.Font = new System.Drawing.Font("Segoe UI", 9);
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 43, 71);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            grid.EnableHeadersVisualStyles = false;
            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
        }

        private void SetupStatCard(System.Windows.Forms.Label lbl, string text, int left, int top)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(left, top);
            lbl.Size = new System.Drawing.Size(150, 80);
            lbl.BackColor = System.Drawing.Color.White;
            lbl.ForeColor = System.Drawing.Color.FromArgb(31, 43, 71);
            lbl.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}