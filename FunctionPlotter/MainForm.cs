using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "FunktionsFormulare";
            IsMdiContainer = true;

            // Menüleiste erstellen
            var menuStrip = new MenuStrip();

            // Menü "Funktionen"
            var funktionsMenu = new ToolStripMenuItem("Funktion");
            var linearMenuItem = new ToolStripMenuItem("Lineare Funktion");
            var quadratischeMenuItem = new ToolStripMenuItem("Quadratische Funktion");
            var exponentialMenuItem = new ToolStripMenuItem("Exponentiale Funktion");
            var ganzrationaleMenuItem = new ToolStripMenuItem("Ganzrationale Funktion");

            // Menü-Events
            linearMenuItem.Click += (s, e) => OpenForm(new LinearFunktionForm());
            quadratischeMenuItem.Click += (s, e) => OpenForm(new QuadratischeFunktionForm());
            exponentialMenuItem.Click += (s, e) => OpenForm(new ExponentialFunktionForm());
            ganzrationaleMenuItem.Click += (s, e) => OpenForm(new GanzrationaleFunktionForm());

            // Menüpunkte hinzufügen
            funktionsMenu.DropDownItems.Add(linearMenuItem);
            funktionsMenu.DropDownItems.Add(quadratischeMenuItem);
            funktionsMenu.DropDownItems.Add(exponentialMenuItem);
            funktionsMenu.DropDownItems.Add(ganzrationaleMenuItem);

            // Menüleiste hinzufügen
            menuStrip.Items.Add(funktionsMenu);
            MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);
        }

        private void OpenForm(Form form)
        {
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }
    }
}