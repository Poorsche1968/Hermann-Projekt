namespace FunktionZeichnen
{
    //Abstrakte Basisklasse für mathematische Funktionen
    public abstract class Funktion
    {
        #region Abstrakte Methode zur Berechnung des Funktionswertes

        //Diese Methode muss in abgeleiteten Klassen überschrieben werden.
        //Sie nimmt einen x-Wert als Eingabe und gibt den berechneten y-Wert zurück.
        public abstract double Berechne(double x);

        #endregion

        #region Virtuelle Methode zur Funktionsbeschreibung

        //Gibt den Typ der Funktion zurück.
        //Diese Methode kann in abgeleiteten Klassen überschrieben werden, um genauere Bezeichnungen zu liefern.
        public virtual string AuswhalFunktionsTyp()
        {
            return "Basisfunktion"; //Standardwert, falls nicht überschrieben
        }

        #endregion
    }
}