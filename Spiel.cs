namespace KartenSpiel
{
    public class Spiel
    {
        public List<Karte> HauptStapel { get; set; } = new List<Karte>();

        public List<Karte> CreateStapel()
        {

            List<Karte> stapel = new List<Karte>();
            for (int i = 2; i < 15; i++)
            {
                //Hier kann man ändern: nur 2 oder 1 karte erstellen.
                Karte karte1 = new Karte(KartenFarbe.Herz, (KartenWert)i);
                Karte karte2 = new Karte(KartenFarbe.Pik, (KartenWert)i);
                Karte karte3 = new Karte(KartenFarbe.Karo, (KartenWert)i);
                Karte karte4 = new Karte(KartenFarbe.Kreuz, (KartenWert)i);
                stapel.Add(karte1);
                stapel.Add(karte2);
                stapel.Add(karte3);
                stapel.Add(karte4);
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
