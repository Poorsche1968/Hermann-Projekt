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
    // Formular zur Darstellung einer Ganzrationalefunktion
    public partial class GanzrationaleFunktionForm : Form
    {
        private Koordinatensystem _graphPanel;// Panel zur Anzeige des Graphen
        public GanzrationaleFunktionForm()
        {
            InitializeComponent(); 
            Text = "Ganzrationale Funktion";// Titel des Fensters setzen

            // UI-Elemente erstellen
            var labelKoeffizienten = new Label() { Text = "Koeffizienten (durch Komma getrennt):", Top = 20, Left = 20 }; // Label für die Koeffizienteneingabe
            var textBoxKoeffizienten = new TextBox() { Top = 20, Left = 200, Width = 220 };// Eingabefeld für Koeffizienten
            var buttonZeichnen = new Button() { Text = "Zeichnen", Top = 60, Left = 20 };// Button zum Zeichnen der Funktion


            // GraphPanel zur Darstellung der Funktion hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 100, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);

            // Event-Handler für den Button-Klick
            buttonZeichnen.Click += (sender, e) =>
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
            };

            // UI-Elemente dem Formular hinzugefügt
            Controls.Add(labelKoeffizienten);
            Controls.Add(textBoxKoeffizienten);
            Controls.Add(buttonZeichnen);
        }
    }
}