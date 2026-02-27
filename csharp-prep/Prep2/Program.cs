using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade < 60)
        {
            Console.WriteLine("Your grade is a F.");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Your grade is an B.");
        }
        else
        {
            Console.WriteLine("Your grade is an A.");
        }

    }
}