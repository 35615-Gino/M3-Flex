using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;


            //koop 2 controllers

            controllersInMandje = controllersInMandje + 2;

            //hij is in voorraad snel kopen!
            int ps5 = 0;

            //koop 1 ps5

            ps5= ps5 ++;

            //koop de games:

            int eldenRing = 0;

            int shantae = 0;

            int spongebob = 0;

            eldenRing +=1;
            shantae +=1;
            spongebob +=1;
            
            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1

            shantae -=1;

            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = 0;// controllersInMandje keer controllerPrijs
            totaalControllerPrijs = controllerPrijs * controllersInMandje;
            double TotaalgamePrijs = 0;// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)

            TotaalgamePrijs = eldenRing * gamePrijs + shantae * gamePrijs + spongebob * gamePrijs;


            double totaalPrijs = 0;// tel hier alles bij elkaar op
            totaalPrijs = TotaalgamePrijs + totaalControllerPrijs + ps5Prijs;

            //er moet nu 759.95 staan
            Console.WriteLine(totaalPrijs);
        }
    }
}