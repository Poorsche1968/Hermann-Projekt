using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class GanzrationaleFunktionForm : Form
    {
        #region Ganzrationale Funktion Formular
        private Koordinatensystem _koordinatensystem;// Panel zur Anzeige des Graphen
        public GanzrationaleFunktionForm()
        {
            InitializeComponent();//Startet das Formular
            Text = "Ganzrationale Funktion";// Titel des Fensters setzen

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

        #region Funktion zeichnen
        private void buttonZeichnen_Click(object sender, EventArgs e)
        {
            try
            {
                //Eingabe parsen: Trennen nach Kommas, Leerzeichen entfernen und in Double umwandeln

                double[] koeffizienten = textBoxKoeffizienten.Text//Eingabe der Koeffizienten
                    .Split(',')                                   //Trennung nach Kommas
                    .Select(c => double.Parse(c.Trim()))          //Leerzeichen entfernen und in Double umwandeln
                    .ToArray();                                   //In Array speichern

                //Ganzrationale Funktion erstellen
                var ganzrationaleFunktion = new GanzrationaleFunktion(koeffizienten);//Ganzrationale Funktion erstellen
                _koordinatensystem.SetzeFunktion(ganzrationaleFunktion);             //Funktion im GraphPanel setzen

                //Nachricht mit der gezeichneten Funktion anzeigen
                MessageBox.Show($"Funktion gezeichnet: y = {string.Join(" + ", koeffizienten.Select((c, i) => $"{c}x^{koeffizienten.Length - 1 - i}"))}"); //Anzeige der Funktion
                label1.Text = $"Funktion: y = {string.Join(" + ", koeffizienten.Select((c, i) => $"{c}x^{koeffizienten.Length - 1 - i}"))}";
            }
            catch
            {
                //Fehlermeldung, falls die Eingabe ungültig ist
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie Zahlen Werte ein, getrennt durch Kommas.");
            }
        }
        #endregion

        #region Formblatt schließen
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hilfe anzeigen
        // Hilfe anzeigen
        private void buttonHilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine ganzrationale Funktion hat die Form f(x) = a_n*x^n + a_(n-1)*x^(n-1) + ... + a_1*x + a_0 , wobei a_n, a_(n-1), ..., a_1, a_0 Konstanten sind; Sie beschreibt eine Kurve, die durch Polynome höheren Grades dargestellt wird.");
        }
        #endregion
    }
}