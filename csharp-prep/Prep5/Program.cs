using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);

        int year;
        PromptUserBirthYear(out year);

        DisplayResult(name, sqNumber, year);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(string name, int number, int year )
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");

        int age = 2026 - year;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }


}