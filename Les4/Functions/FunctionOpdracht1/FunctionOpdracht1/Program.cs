using System;

namespace FunctionOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eerst even uit de static ontsnappen
            Program program = new Program();

            program.Run();//roep hier de function Run aan
            program.ShowThis("kaas");//roep hier de function ShowThis aan
        }

        private void Run()
        {
            Console.WriteLine("function run reporting!");
        }


        private void ShowThis(string showThisText)
        {
            Console.WriteLine(showThisText);
        }
    }
}