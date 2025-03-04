using System;
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


            // GraphPanel hinzufügen
            _graphPanel = new Koordinatensystem() { Top = 150, Left = 20, Width = 800, Height = 600 };
            Controls.Add(_graphPanel);
        }

        private void LinearFunktionForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonZeichnen_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNeigung.Text, out double steigung) && double.TryParse(textBoxAbfangen.Text, out double achsenabschnitt))
            {
                var linearFunction = new LineareFunktion(steigung, achsenabschnitt);
                _graphPanel.SetFunktion(linearFunction);
                label1.Text = $"Funktion: y = {steigung}x + {achsenabschnitt}"; // Anzeige im Label
            }
            else
            {
                label1.Text = "Ungültige Eingabe. Bitte geben Sie numerische Werte ein."; // Fehler im Label anzeigen
            }

            /*
            // UI-Elemente hinzufügen
            Controls.Add(labelNeigung);
            Controls.Add(textBoxNeigung);
            Controls.Add(labelAbfangen);
            Controls.Add(textBoxAbfangen);
            Controls.Add(buttonZeichnen);*/
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine lineare Funktion hat die Form f(x) = m*x + b , wobei m die Steigung und b der y-Achsenabschnitt ist; Sie beschreibt eine gerade Linie mit konstanter Steigung.");
        }
    }
}
