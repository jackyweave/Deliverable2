using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "! Do you want to do the COIN FLIP CHALLENGE? (Yes/No)");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "no")
        {
            Console.WriteLine( name + " is a Coward! Program ended.");
        }
        else if (choice.ToLower() == "yes")
        {
            int totalCorrect = 0;

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int randomNumber = rnd.Next(2); 

                Console.WriteLine("Round " + (i + 1) + ": Guess heads or tails (0/1):");
                int userGuess;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out userGuess) && (userGuess == 0 || userGuess == 1))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter 0 for heads or 1 for tails.");
                }

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Correct!");
                    totalCorrect++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine(name + ", you got a score of : " + totalCorrect);
        }
        else
        {
            Console.WriteLine("Invalid choice. Program ended.");
        }
    }
}
