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
    public partial class LinearFunktionForm : Form
    {
        private Koordinatensystem _graphPanel;
        public LinearFunktionForm()
        {
            InitializeComponent();
            Text = "Lineare Funktion";

            // UI-Elemente
            var labelNeigung = new Label() { Text = "Neigung (m):", Top = 20, Left = 20 };
            var textBoxNeigung = new TextBox() { Top = 20, Left = 120, Width = 90 };
            var labelAbfangen = new Label() { Text = "Abfangen (b):", Top = 60, Left = 20 };
            var textBoxAbfangen = new TextBox() { Top = 60, Left = 120, Width = 90 };
            var buttonZeichnen = new Button() { Text = "Zeichen", Top = 100, Left = 20 };

            // GraphPanel hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 150, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);

            // Button-Klick-Event
            buttonZeichnen.Click += (sender, e) =>
            {
                if (double.TryParse(textBoxNeigung.Text, out double neigung) && double.TryParse(textBoxAbfangen.Text, out double abfangen))
                {
                    var linearFunction = new LineareFunktion(neigung, abfangen);
                    _graphPanel.SetFunktion(linearFunction);
                    MessageBox.Show($"Funktion zeichnen: y = {neigung}x + {abfangen}");
                }
                else
                {
                    MessageBox.Show("Ungültige Eingabe. Bitte geben Sie numerische Werte ein.");
                }
            };

            // UI-Elemente hinzufügen
            Controls.Add(labelNeigung);
            Controls.Add(textBoxNeigung);
            Controls.Add(labelAbfangen);
            Controls.Add(textBoxAbfangen);
            Controls.Add(buttonZeichnen);
        }
    }
}