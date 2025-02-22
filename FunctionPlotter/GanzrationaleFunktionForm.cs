﻿using System;
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
    }
}