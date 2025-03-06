using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class LinearFunktionForm : Form
    {
        private Koordinatensystem _graphPanel;

        #region Initialisierung der Form
        public LinearFunktionForm()
        {
            InitializeComponent();
            Text = "Lineare Funktion";// Titel der Form


            _graphPanel = new Koordinatensystem() { Top = 150, Left = 20, Width = 800, Height = 600 };// GraphPanel erstellen
            Controls.Add(_graphPanel);// GraphPanel hinzufügen
        }
        #endregion

        #region GraphPanel zeichnen lassen
        private void buttonZeichnen_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNeigung.Text, out double steigung) && double.TryParse(textBoxAbfangen.Text, out double achsenabschnitt))
            {
                var lineareFunktion = new LineareFunktion(steigung, achsenabschnitt);// Lineare Funktion erstellen
                _graphPanel.SetFunktion(lineareFunktion);// Funktion setzen
                label1.Text = $"Funktion: y = {steigung}x + {achsenabschnitt}"; // Anzeige im Label
            }
            else
            {
                label1.Text = "Ungültige Eingabe. Bitte geben Sie Zahlen Werte ein."; // Fehlermeldung
            }
        }
        #endregion

        //Form schließen
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Hilfe anzeigen
        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine lineare Funktion hat die Form f(x) = m*x + b , wobei m die Steigung und b der y-Achsenabschnitt ist; Sie beschreibt eine gerade Linie mit konstanter Steigung.");
        }
    }
}
