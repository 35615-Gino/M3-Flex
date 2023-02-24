namespace CSharpOpdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //maak een string
            string text = "Hello, Wordl!";

            //Hiermee kan je de kleur van de letters veranderen.
            Console.ForegroundColor
            = ConsoleColor.Green;

            //om het woord te laten verschijnen moeten we een foreach loop maken
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(75);
                //de Thread zorgt ervoor hoe snel het woord word uitgetyped.
                //Hoe hoger het getal hoe langer hij er over doet en hoe kleiner het getal hoe sneller die het uit typed 
            }
            //Readkey zorgt ervoor dat die de loop gebruikt
            Console.ReadKey();


        }
    }
}