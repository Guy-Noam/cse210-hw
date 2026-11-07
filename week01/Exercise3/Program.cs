using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generates a random number between 1 and 100

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

    Console.WriteLine("You guessed it!");

    }
}   