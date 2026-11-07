using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        Console.WriteLine($"Hello {userName}");

        int userNumber = PromptUserNumber();
        Console.WriteLine($"Your favorite number is: {userNumber}");

        int squaredNumber = SquareNumber(userNumber);
        Console.WriteLine($"Your favorite number squared is: {squaredNumber}");

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine()!;
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine()!);
        return number;
    }   

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}