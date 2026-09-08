using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int counter = 0;

        while (guess != magicNumber)
        {
            counter++;
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it! It took you " + counter + " tries.");
                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "y")
                {
                    magicNumber = randomGenerator.Next(1, 101);
                    guess = -1;
                    counter = 0;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher. ");
            }
            else
            {
                Console.WriteLine("Lower. ");
            }
        }
    }
}