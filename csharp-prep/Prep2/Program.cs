using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("Try harder next time.");
        }


        Console.WriteLine($"Your grade is a {letter}.");

    }
}