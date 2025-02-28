using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class ExponentialFunktionForm : Form
    {
        private Koordinatensystem _koordinatensystem;

        public ExponentialFunktionForm()
        {
            InitializeComponent();
            Text = "ExponentialFunktion";

            // Panel hinzugefügt
            _koordinatensystem = new Koordinatensystem() { Top = 100, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_koordinatensystem);

            // UI-Elemente hinzufügen
            Controls.Add(labelBasis);
            Controls.Add(textBoxBasis);
            Controls.Add(buttonZeichne);
        }

        private void buttonZeichne_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxBasis.Text, out double basisWert) && basisWert > 0)
            {
                var expFunktion = new ExponentialFunktion(basisWert);
                _koordinatensystem.SetFunktion(expFunktion);
                MessageBox.Show($"Funktion Zeichnen: y = {basisWert}^x");
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie einen positiven numerischen Wert ein.");
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine Exponentialfunktion hat die Form f(x) = a^x , wobei a eine positive Konstante ist; Sie beschreibt eine Kurve, die exponentiell wächst oder fällt.");
        }
    }
}

