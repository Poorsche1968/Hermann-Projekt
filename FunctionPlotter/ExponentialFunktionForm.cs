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

            // UI-Elemente
            var labelBasis = new Label() { Text = "Basis Funktion (a):", Top = 20, Left = 20 };
            var textBoxBasis = new TextBox() { Top = 20, Left = 120, Width = 90 };
            var buttonZeichne = new Button() { Text = "Zeichne", Top = 60, Left = 20 };

            // Panel hinzugefügt
            _koordinatensystem = new Koordinatensystem() { Top = 100, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_koordinatensystem);

            // Button-Klick-Event
            buttonZeichne.Click += (sender, e) =>
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
            };

            // UI-Elemente hinzufügen
            Controls.Add(labelBasis);
            Controls.Add(textBoxBasis);
            Controls.Add(buttonZeichne);
        }
    }
}

