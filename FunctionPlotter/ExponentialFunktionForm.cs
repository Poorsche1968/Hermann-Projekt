using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class ExponentialFunktionForm : Form
    {
        private Koordinatensystem _koordinatensystem;

        #region Exponential Funktion Formular
        public ExponentialFunktionForm()
        {
            InitializeComponent();
            Text = "ExponentialFunktion";

            // Koordinatensystem hinzufügen
            _koordinatensystem = new Koordinatensystem() { Top = 100, Left = 20, Width = 800, Height = 600 }; // Position und Größe des Koordinatensystems
            Controls.Add(_koordinatensystem); // Koordinatensystem dem Formular hinzufügen
        }
        #endregion

        #region Funktion Zeichnen
        private void buttonZeichne_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxBasis.Text, out double basisWert) && basisWert > 0)  // Prüfen, ob die Eingabe eine positive Zahl ist
            {
                var expFunktion = new ExponentialFunktion(basisWert);                       // Exponentialfunktion erstellen
                _koordinatensystem.SetzeFunktion(expFunktion);                               // Funktion dem Koordinatensystem hinzufügen
                MessageBox.Show($"Funktion Zeichnen: y = {basisWert}^x");                 // Meldung anzeigen
                label1.Text = $"Funktion: y = {basisWert}^x";                            // Funktion in Label anzeigen
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie einen positiven numerischen Wert ein."); // Fehlermeldung anzeigen
            }
        }
        #endregion

        // Form schließen
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hilfe anzeigen
        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine Exponentialfunktion hat die Form f(x) = a^x , wobei a eine positive Konstante ist; Sie beschreibt eine Kurve, die exponentiell wächst oder fällt.");
        }
    }
}

