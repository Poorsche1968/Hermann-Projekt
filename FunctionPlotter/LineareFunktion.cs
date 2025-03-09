namespace FunktionZeichnen
{
    public class LineareFunktion : Funktion
    {
        public double m { get; set; }
        public double b { get; set; }

        public LineareFunktion(double steigung, double schnittpunkt_y_achse)
        {
            m = steigung;
            b = schnittpunkt_y_achse;
        }

        public override double Berechne(double x)
        {
            return m * x + b;
        }

        public override string AuswhalFunktionsTyp()
        {
            return "Lineare Funktion";
        }
    }
}