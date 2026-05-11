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

            // Пункты меню
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

            // MainForm
            this.Text = "Турагентство";
            this.Size = new System.Drawing.Size(900, 600);
            this.MainMenuStrip = this.menuStrip;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
        }
    }
}