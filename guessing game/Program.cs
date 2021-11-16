using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum;
            int guessedNum;
            bool wrongAns = true;
            randomNum = random.Next(1, 101);

            Console.WriteLine("Guessing game");
            Console.WriteLine("______________");
            Console.WriteLine("I think about number from 1 to 100");
            


            while (wrongAns)
            {
                Console.WriteLine("Guess random number:");
                guessedNum = int.Parse(Console.ReadLine());
                if (guessedNum > randomNum)
                {
                    Console.WriteLine("Too high");
                }
                else if (guessedNum < randomNum)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("You´re right");
                    wrongAns = false;
                }
                
            }
        }
    }
}
