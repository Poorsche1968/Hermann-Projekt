using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class LinearFunktionForm : Form
    {
        #region Lineare Funktion Formular 
        private Koordinatensystem _koordinatensystem;
        
        public LinearFunktionForm()
        {
            InitializeComponent();
            Text = "Lineare Funktion";// Titel der Form


            //Erstellt ein neues Koordinatensystem und legt seine Position und Größe fest
            _koordinatensystem = new Koordinatensystem()
            {
                Top = 150,    //Abstand von der oberen Kante des Formulars
                Left = 20,    //Abstand von der linken Kante des Formulars
                Width = 800,  //Breite des Koordinatensystems
                Height = 600  //Höhe des Koordinatensystems
            };

            //Fügt das Koordinatensystem dem Formular hinzu, sodass es angezeigt wird
            Controls.Add(_koordinatensystem);
        }
        #endregion

        #region Funktion Zeichnen
        private void buttonZeichnen_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNeigung.Text, out double steigung) && double.TryParse(textBoxAbfangen.Text, out double achsenabschnitt))
            {
                var lineareFunktion = new LineareFunktion(steigung, achsenabschnitt);// Lineare Funktion erstellen
                _koordinatensystem.SetzeFunktion(lineareFunktion);// Funktion setzen
                label1.Text = $"Funktion: y = {steigung}x + {achsenabschnitt}"; // Anzeige im Label
            }
            else
            {
                label1.Text = "Ungültige Eingabe. Bitte geben Sie Zahlen Werte ein."; // Fehlermeldung
            }
        }
        #endregion

        #region Form schließen
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hilfe anzeigen
        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine lineare Funktion hat die Form f(x) = m*x + b , wobei m die Steigung und b der y-Achsenabschnitt ist; Sie beschreibt eine gerade Linie mit konstanter Steigung.");
        }
        #endregion
    }
}
