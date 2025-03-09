using System;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class ExponentialFunktionForm : Form
    {
        #region Exponential Funktion Formular
        //Erstellt eine Instanz (objekt) der Klasse "Koordinatensystem", um die Funktion zu zeichnen.
        private Koordinatensystem _koordinatensystem;

        //Konstruktor für das Formular
        public ExponentialFunktionForm()
        {
            InitializeComponent();//Startet das Formular

            Text = "ExponentialFunktion";//Legt den Titel des Fensters fest


            //Erstellt ein neues Koordinatensystem und legt seine Position und Größe fest
            _koordinatensystem = new Koordinatensystem()
            {
                Top = 100,    //Abstand von der oberen Kante des Formulars
                Left = 20,    //Abstand von der linken Kante des Formulars
                Width = 800,  //Breite des Koordinatensystems
                Height = 600  //Höhe des Koordinatensystems
            };

            //Fügt das Koordinatensystem dem Formular hinzu, sodass es angezeigt wird
            Controls.Add(_koordinatensystem);
        }
        #endregion

        #region Funktion Zeichnen
        private void buttonZeichne_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxBasis.Text, out double basisWert) && basisWert > 0)  // Prüfen, ob die Eingabe eine positive Zahl ist
            {
                var expFunktion = new ExponentialFunktion(basisWert);                       // Exponentialfunktion erstellen
                _koordinatensystem.SetzeFunktion(expFunktion);                               // Funktion dem Koordinatensystem hinzufügen
                MessageBox.Show($"Funktion Zeichnen: y = {basisWert}^x");                 // Meldung anzeigen
                label1.Text = $"Funktion: y = {basisWert}^x";                            // Funktion in Label anzeigen
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie einen positiven numerischen Wert ein."); // Fehlermeldung anzeigen
            }
        }
        #endregion

        #region Formblatt schließen
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hilfeanzeige
        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine Exponentialfunktion hat die Form f(x) = a^x , wobei a eine positive Konstante ist; Sie beschreibt eine Kurve, die exponentiell wächst oder fällt.");
        }
        #endregion
    }
}

