using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int squaredNumber = FavoriteNumber();

        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int FavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        int squaredNumber = favoriteNumber * favoriteNumber;
        return squaredNumber;
    }
}