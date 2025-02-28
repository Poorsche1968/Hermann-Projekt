using System;
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

            

            // GraphPanel hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 200, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);
        }


        private void buttonZeichne_Click(object sender, EventArgs e)
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
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 