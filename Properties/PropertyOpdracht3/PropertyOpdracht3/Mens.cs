using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        public int Leeftijd
        {
            get {
                return leeftijd;
            }
            set
            {
                if(value > leeftijd)
                {
                    leeftijd = value;
                    Console.WriteLine("geen probleem even iets ouder!");
                }
                else
                {
                    Console.WriteLine("dat kan niet!");
                }
            }
        }

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}