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
    }
}

