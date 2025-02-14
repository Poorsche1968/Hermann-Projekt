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
    // Formular zur Darstellung einer quadratischen Funktion
    public partial class QuadratischeFunktionForm : Form
    {
        private Koordinatensystem _graphPanel;// Panel zur Darstellung des Graphen
        public QuadratischeFunktionForm()
        {
            InitializeComponent();
            Text = "Quadratische Funktion";// Titel des Fensters setzen

            // UI-Elemente erstellen
            var labelA = new Label() { Text = "A:", Top = 20, Left = 20 };
            var textBoxA = new TextBox() { Top = 20, Left = 120, Width = 90 };
            var labelB = new Label() { Text = "B:", Top = 60, Left = 20 };
            var textBoxB = new TextBox() { Top = 60, Left = 120, Width = 90 };
            var labelC = new Label() { Text = "C:", Top = 100, Left = 20 };
            var textBoxC = new TextBox() { Top = 100, Left = 120, Width = 90 };
            var buttonZeichne = new Button() { Text = "Plot", Top = 140, Left = 20 };

            // GraphPanel hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 200, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);

            // Button-Klick-Event
            buttonZeichne.Click += (sender, e) =>
            {
                if (double.TryParse(textBoxA.Text, out double a) &&
                    double.TryParse(textBoxB.Text, out double b) &&
                    double.TryParse(textBoxC.Text, out double c))
                {
                    var quadratischeFunktion = new QuadratischeFunktion(a, b, c);
                    _graphPanel.SetFunktion(quadratischeFunktion);
                    double[] wurzel = quadratischeFunktion.BerechneWurzeln();

                    string nachricht = $"Funktion gezeichnet: y = {a}x² + {b}x + {c}\n";
                    if (wurzel.Length == 0)
                        nachricht += "Keine reellen Nullstellen.";
                    else
                        nachricht += $"Nullstellen: x1 = {wurzel[0]}, x2 = {wurzel[1]}";

                    MessageBox.Show(nachricht);
                }
                else
                {
                    MessageBox.Show("Ungültige Eingabe. Bitte geben Sie numerische Werte ein.");
                }
            };

            // UI-Elemente hinzufügen
            Controls.Add(labelA);
            Controls.Add(textBoxA);
            Controls.Add(labelB);
            Controls.Add(textBoxB);
            Controls.Add(labelC);
            Controls.Add(textBoxC);
            Controls.Add(buttonZeichne);
        }
    }
} 