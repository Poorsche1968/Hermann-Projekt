using System;

namespace FunktionZeichnen
{
    //Die Klasse der Exponentiel Funktion wird erstellt und wird vererbt mit der Grund Funktion
    public class ExponentialFunktion : Funktion 
    {
        #region Automatisch implementierte Eigenschaften
        //Automatisch implementierte Eigenschaft zur Speicherung der Basis der Exponentialfunktion
        public double a { get; set; }
        #endregion

        #region Konstruktor
        //Konstruktor der Klasse zur Darstellung einer Exponentialfunktion
        public ExponentialFunktion(double a_Größe)
        {
            a = a_Größe; //Setzt die Basis der Exponentialfunktion
        }
        #endregion

        #region Methoden
        //Methode zur Berechnung des Funktionswertes für ein gegebenes x
        public override double Berechne(double x)
        {
            return Math.Pow(a, x); //Berechnet a^x
        }

        //Methode zur Rückgabe des Funktionsnamens
        public override string AuswhalFunktionsTyp()
        {
            return "Exponential Funktion"; //Gibt den Funktionsname der Funktion zurück
        }
        #endregion
    }
}