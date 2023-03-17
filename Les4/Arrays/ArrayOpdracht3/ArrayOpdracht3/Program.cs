using System;

namespace ArrayOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] nameparts = new string[] { "mar", "chu" , "io", "li",  "pika", "nk" };


            Console.WriteLine(nameparts[0] + nameparts[2]);

            //maak nu de volgende namen en schrijf het naar de console:

            //link
            Console.WriteLine(nameparts[3] + nameparts[5]);

            //pikachu
            Console.WriteLine(nameparts[4]+ nameparts[1]);

            //linkio
            Console.WriteLine(nameparts[3]+ nameparts[5] + nameparts[2]);
            //chumar
            Console.WriteLine(nameparts[1] + nameparts[0]);
        }
    }
}