namespace KartenSpiel
{
    public class Karte
    {
        public Karte(KartenFarbe farbe, KartenWert wert )
        {
            Farbe = farbe;
            Wert = wert;
        }

        public KartenFarbe Farbe { get; set; }
        public KartenWert Wert { get; set; }
    }
}
