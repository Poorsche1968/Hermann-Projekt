using System;

namespace FunktionZeichnen
{
    // Die Klasse der Exponentiel Funktion wird erstellt und wird vererbt mit der Grund Funktion
    public class ExponentialFunktion : Funktion 
    {
        // Eigenschaft zur Speicherung der Basis der Exponentialfunktion
        public double Basis { get; set; }

        // Klasse zur Darstellung einer Exponentialfunktion
        public ExponentialFunktion(double BasisGröße)
        {
            Basis = BasisGröße; // Setzt die Basis der Exponentialfunktion
        }

        // Methode zur Berechnung des Funktionswertes für ein gegebenes x
        public override double Berechne(double x)
        {
            return Math.Pow(Basis, x); // Berechnet Base^x
        }

        // Methode zur Rückgabe des Funktionsnamens
        public override string AuswhalFunktionsTyp()
        {
            return "Exponential Funktion"; // Gibt den Funktionsname der Funktion zurück
        }
    }
}