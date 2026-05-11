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

            // MenuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileMenu,
                this.agenciesMenuItem,
                this.toursMenuItem,
                this.bookingsMenuItem
            });

            // Файл
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
                this.addAgencyButton,
                this.editAgencyButton,
                this.deleteAgencyButton,
                this.searchAgencyBox,
                this.searchAgencyButton
            });

            // DataGridView агентств
            this.agenciesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenciesGrid.ReadOnly = true;
            this.agenciesGrid.AllowUserToAddRows = false;
            this.agenciesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agenciesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.agenciesTab.Controls.Add(this.agenciesGrid);
            this.agenciesTab.Controls.Add(this.agencyButtonPanel);

            // MainForm
            this.Text = "Турагентство";
            this.Size = new System.Drawing.Size(900, 600);
            this.MainMenuStrip = this.menuStrip;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
        }
    }
}