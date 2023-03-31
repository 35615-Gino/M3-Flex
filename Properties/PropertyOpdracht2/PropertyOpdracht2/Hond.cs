namespace PropertyOpdracht1
{
    internal class Hond
    {
        public string Naam { get; private set; } //maak hier een property Naam, de set moet private zijn!
        public Hond(string naam)
        {
            this.Naam = naam;
        }

    }
}