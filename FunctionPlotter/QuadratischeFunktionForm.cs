using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class QuadratischeFunktionForm : Form
    {
        #region Quadratische Funktions Formular

        private Koordinatensystem _koordinatensystem;// Panel zur Darstellung des Graphen
        
        public QuadratischeFunktionForm()
        {
            InitializeComponent();
            Text = "Quadratische Funktion";// Titel des Fensters setzen

            //Erstellt ein neues Koordinatensystem und legt seine Position und Größe fest
            _koordinatensystem = new Koordinatensystem()
            {
                Top = 200,    //Abstand von der oberen Kante des Formulars
                Left = 20,    //Abstand von der linken Kante des Formulars
                Width = 800,  //Breite des Koordinatensystems
                Height = 600  //Höhe des Koordinatensystems
            };

            //Fügt das Koordinatensystem dem Formular hinzu, sodass es angezeigt wird
            Controls.Add(_koordinatensystem);
        }
        #endregion

        #region Funktion zeichnen
        private void buttonZeichne_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxA.Text, out double a) && double.TryParse(textBoxB.Text, out double b) && double.TryParse(textBoxC.Text, out double c))// Eingabe überprüfen
            {
                var quadratischeFunktion = new QuadratischeFunktion(a, b, c);// Quadratische Funktion erstellen 
                _koordinatensystem.SetzeFunktion(quadratischeFunktion);               // Funktion setzen
                double[] wurzel = quadratischeFunktion.BerechneWurzeln();    // Nullstellen berechnen

                string nachricht = $"Funktion gezeichnet: y = {a}x² + {b}x + {c}\n";// Nachricht zusammenstellen
                if (wurzel.Length == 0)                                             // Nullstellen ausgeben
                    nachricht += "Keine reellen Nullstellen.";                      // Keine Nullstellen
                else
                    nachricht += $"Nullstellen: x1 = {wurzel[0]}, x2 = {wurzel[1]}";// Nullstellen ausgeben

                MessageBox.Show(nachricht);
                label1.Text = $"f(x) = {a}x² + {b}x + {c}";// Funktion anzeigen
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie Zahlen Werte ein.");// Fehlermeldung
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
            MessageBox.Show("Eine quadratische Funktion hat die Form f(x) = a*x² + b*x + c , wobei a, b und c Konstanten sind; Sie beschreibt eine Parabel.");
        }
        #endregion
    }
} 