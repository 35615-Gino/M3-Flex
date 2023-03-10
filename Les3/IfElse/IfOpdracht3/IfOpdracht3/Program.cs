using System;

namespace IfOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //we gaan de AND opertator (&&) gebruiken
            //een lekker ijsje, alleen welke smaken kiezen we?

            //maak van 2 false hieronder true
            bool chocola = true;
            bool vanilla = true;
            bool aardbei = false;



            if (chocola && vanilla)//test hier of je chocola AND vanilla hebt gekozen 
            {
                Console.WriteLine("hier is je chocola vanilla ijsje"); 
            }
            else if (chocola && aardbei)//test hier of je chocola AND aardbei hebt gekozen 
            {
                Console.WriteLine("hier is je chocola aardbei ijsje"); 
            }
            else if (vanilla && aardbei)//test hier of je vanilla AND aardbei hebt gekozen 
            {
                Console.WriteLine("hier is je vanilla aardbei ijsje"); 
            }
        }
    }
}