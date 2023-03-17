using System;

namespace ArrayOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak een array van 10 enemies het onderstaande code blok gaat werken
            Enemy[] enemies = new Enemy[10];


            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new Enemy(i);
            }

        }
    
    }

}