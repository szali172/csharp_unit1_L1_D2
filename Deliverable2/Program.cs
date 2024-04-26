using System;


// Initialize username
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

// They opted out
Console.WriteLine("Welcome " + name + ", Do you want to do the COIN FLIP CHALLENGE?");
string userChoice = Console.ReadLine().ToLower();
if (userChoice == "no")
{
    Console.WriteLine("Coward...");
    Console.ReadLine();
}

// They're starting the challenge
else if (userChoice == "yes")
{
    Console.WriteLine("The challenge begins...");
    int score = 0;
    Random RNG = new Random();

    // Play 5 rounds
    for (int i = 0; i < 5; i++)
    {
        // Ask user for heads or tails
        Console.WriteLine("Heads or Tails?");
        string choice = Console.ReadLine();

        // Generate a random number and compare it with user input
        int rand_number = RNG.Next(0, 2);
        if (rand_number == 0 && choice == "Heads")
        {
            Console.WriteLine("Correct!");
            score += 1;
        }
        else if (rand_number > 0 && choice == "Tails")
        {
            Console.WriteLine("Correct!");
            score += 1;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }

    Console.WriteLine("Thanks for playing " + name + "! You got a score of " + score);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Improper input detected");
    Console.ReadLine();
}