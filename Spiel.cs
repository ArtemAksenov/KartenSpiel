namespace KartenSpiel
{
    public class Spiel
    {
        public List<Karte> HauptStapel { get; set; } = new List<Karte>();
        public List<Karte> Stapel1 { get; set; } = new List<Karte>();
        public List<Karte> Stapel2 { get; set; } = new List<Karte>();


        public List<Karte> CreateStapel(KartenFarbe farbe)
        {

            List<Karte> stapel = new List<Karte>();
            for (int i = 2; i < 15; i++)
            {
                Karte karte1 = new Karte(farbe, (KartenWert)i);
                stapel.Add(karte1);
            }
            return stapel;
        }

        public List<Karte> MixZweiStapel(List<Karte> stapel1, List<Karte> stapel2)
        {
            List<Karte> stapel = new List<Karte>();
            stapel.AddRange(stapel1);
            stapel.AddRange(stapel2);
            int zahl;
            Random rand = new Random();
            Karte karte;
            for (int i = 0; i < 1000; i++)
            {
                zahl = rand.Next(0, stapel.Count());
                karte = stapel[zahl];
                stapel.Remove(karte);
                stapel.Add(karte);
            };
            return stapel;
        }

    }
}
