namespace KartenSpiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Spiel spiel = new Spiel();

            spiel.Stapel1 = spiel.CreateStapel(KartenFarbe.Karo);
            spiel.Stapel2 = spiel.CreateStapel(KartenFarbe.Pik);

            spiel.HauptStapel = spiel.MixZweiStapel(spiel.Stapel1, spiel.Stapel2);
        }
    }
}