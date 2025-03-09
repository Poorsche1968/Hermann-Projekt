namespace FunktionZeichnen
{
    //Die Klasse der Lineare Funktion wird erstellt und wird vererbt mit der Grund Funktion
    public class LineareFunktion : Funktion
    {
        #region Automatisch implementierte Eigenschaften
        //Automatisch implementierte Eigenschaft für die Steigung der linearen Funktion (m in y = mx + b)
        public double m { get; set; }

        //Automatisch implementierte Eigenschaft für den y-Achsenabschnitt der linearen Funktion (b in y = mx + b)
        public double b { get; set; }
        #endregion

        #region Konstruktor
        //Konstruktor, der die Steigung und den y-Achsenabschnitt setzt
        public LineareFunktion(double steigung, double schnittpunkt_y_achse)
        {
            m = steigung; //Weist die übergebene Steigung der Eigenschaft "m" zu
            b = schnittpunkt_y_achse; //Weist den übergebenen y-Achsenabschnitt der Eigenschaft "b" zu
        }
        #endregion

        #region Methoden
        //Überschreibt die Berechnungsmethode aus der Basisklasse "Funktion"
        public override double Berechne(double x)
        {
            return m * x + b; //Berechnet den Funktionswert y = m * x + b
        }

        //Überschreibt eine Methode zur Rückgabe des Funktionsnamens
        public override string AuswhalFunktionsTyp()
        {
            return "Lineare Funktion"; //Gibt den Typ der Funktion als Zeichenkette zurück
        }
        #endregion

    }
}