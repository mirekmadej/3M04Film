namespace _4M04Film
{
    class Film
    {
        protected int liczbaWypozyczen;
        protected string tytul;

        public Film()
        {
            liczbaWypozyczen = 0;
            tytul = string.Empty;
        }
        public void setTytul(string tytul)
        {
            this.tytul = tytul;
        }
        public string getTytul() => this.tytul;
        public int getLiczbaWypozyczen() => this.liczbaWypozyczen;
        public void inkrementujWypozyczenia()
        {
            liczbaWypozyczen += 1;
        }
        public override string ToString() 
            { return $"{tytul}, wypożyczeń: {liczbaWypozyczen}"; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
            Console.WriteLine(film);
            film.setTytul("Pasą się konie na betonie");
            Console.WriteLine($"tytuł filmu: {film.getTytul()}");
            Console.WriteLine($"tytuł filmu: {film.getLiczbaWypozyczen()}");
            Console.WriteLine($"tytuł filmu: {film.getLiczbaWypozyczen()}");
            film.inkrementujWypozyczenia();
            Console.WriteLine($"tytuł filmu: {film.getLiczbaWypozyczen()}");


        }
    }
}
