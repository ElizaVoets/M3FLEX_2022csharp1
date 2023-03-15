using System;

namespace ClassOpdracht1
{

    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 

    //dit is een class
    internal class ClassStructureExercise
    {
        //dit is een class level variable
        private readonly string accountName;

        //dit is een constructor
        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }

        //dit is een function
        internal void ShowGreetingInConsole()
        {
            //dit is een (string) variable
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        //dit is een function
        internal void Show1To10()
        {
            //dit is een for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        //dit is een function
        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

        }
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }
}