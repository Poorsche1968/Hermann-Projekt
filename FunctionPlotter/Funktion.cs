using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunktionZeichnen
{
    // Abstrakte Basisklasse für mathematische Funktionen
    public abstract class Funktion
    {
        // Abstrakte Methode zur Berechnung des Funktionswertes an einer bestimmten Stelle x
        public abstract double Berechne(double x);

        // Methode zur Rückgabe des Funktionstyps als String (kann in Unterklassen überschrieben werden)
        public virtual string GetFunktionsTyp()
        {
            return "Basisfunktion";//Gibt den die Basis Funktion zurück
        }
    }
}