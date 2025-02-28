using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    // Formular zur Darstellung einer Ganzrationalefunktion
    public partial class GanzrationaleFunktionForm : Form
    {
        private Koordinatensystem _graphPanel;// Panel zur Anzeige des Graphen
        public GanzrationaleFunktionForm()
        {
            InitializeComponent(); 
            Text = "Ganzrationale Funktion";// Titel des Fensters setzen

            // GraphPanel zur Darstellung der Funktion hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 100, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);

            // UI-Elemente dem Formular hinzugefügt
            Controls.Add(labelKoeffizienten);
            Controls.Add(textBoxKoeffizienten);
            Controls.Add(buttonZeichnen);
        }

        private void buttonZeichnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Eingabe parsen: Trennen nach Kommas, Leerzeichen entfernen und in Double umwandeln
                double[] koeffizienten = textBoxKoeffizienten.Text
                    .Split(',')
                    .Select(c => double.Parse(c.Trim()))
                    .ToArray();

                // Erstellung der Polynomfunktion mit den eingegebenen Koeffizienten
                var polynomFunktion = new GanzrationaleFunktion(koeffizienten);
                _graphPanel.SetFunktion(polynomFunktion);// Funktion im GraphPanel setzen

                // Nachricht mit der gezeichneten Funktion anzeigen
                MessageBox.Show($"Funktion gezeichnet: y = {string.Join(" + ", koeffizienten.Select((c, i) => $"{c}x^{koeffizienten.Length - 1 - i}"))}");
            }
            catch
            {
                // Fehlermeldung, falls die Eingabe ungültig ist
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie numerische Werte ein, getrennt durch Kommas.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine ganzrationale Funktion hat die Form f(x) = a_n*x^n + a_(n-1)*x^(n-1) + ... + a_1*x + a_0 , wobei a_n, a_(n-1), ..., a_1, a_0 Konstanten sind; Sie beschreibt eine Kurve, die durch Polynome höheren Grades dargestellt wird.");
        }
    }
}