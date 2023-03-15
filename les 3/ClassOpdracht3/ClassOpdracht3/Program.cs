using System;

namespace ClassOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //we gaan de static ontsnappen

            //1) maak een nieuwe class aan die je GameEngine noemt       (gebruik rechter muis op het project ClassOpdracht3->add->new class
            //Done!

            //2) maak hier een nieuwe instance aan van GameEngine
            GameEngine gameEngine = new GameEngine();
           

            //4) roep hier de rungameloop aan 
            gameEngine.RunGameLoop();
           


        }
    }
}