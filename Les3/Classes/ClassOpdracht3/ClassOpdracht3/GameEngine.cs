using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOpdracht3
{
    internal class GameEngine
    {
        internal void RunGameLoop()
        {
            while (true)
            {
                Console.WriteLine("loop 1 time!");
                System.Threading.Thread.Sleep(1000);//usings komen later dus even met System.Threading ervoor ^^
            }
        }
    }
}
