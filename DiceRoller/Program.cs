// Dice Roller Lab

using System.ComponentModel.Design;
using System.Xml.Serialization;

Console.WriteLine("Welcome to the Casino Dice Roller game!\n");

bool runProgram = true;
while (runProgram)
{
    
    Console.WriteLine("Enter 6 for craps to roll dice or enter a different number of sides for your dice to have");
    int sides = 0;
    while (true)        // while (TryParse(Console.ReadLine(), out sides1) == false || sides <= 0) then cw
    {
        try
        {
            sides = int.Parse(Console.ReadLine());
            if (sides > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number");
            }
        }
        catch
        {
            Console.WriteLine("Enter only numbers");
        }
        
    }

    //Random rand = new Random(); <--- removed this and made into a method

    
    // plug in methods 
    int score1 = GetRandom(sides);
    int score2 = GetRandom(sides);
    int sum = score1 + score2;

    Console.WriteLine($"Dice 1 rolled a {score1}");
    Console.WriteLine($"Dice 2 rolled a {score2}");
    Console.WriteLine($"The sum of both dice rolled come out to: {sum}");
    Console.WriteLine(DiceRoll(score1, score2));
    Console.WriteLine(Totals(sum));


    // Ask to continue playing game
    while (true)
    {

        Console.WriteLine("Would you like to continue rolling? y/n");
        string response = Console.ReadLine();

        if (response == "y")
        {
            runProgram = true;
            break;
        }
        else if (response == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please type y or n");
        }
    }
}





// method for total
static string Totals(int sum)
{
    if (sum == 2 || sum == 3 || sum == 12)
    {
        return "craps";
    }
    
    if (sum == 7 || sum == 11)
    {
        return "You Win";
    }
    else
    {
        return "";
    }
}


// method for each dice
static string DiceRoll(int score1, int score2)
{
    if (score1 == 1 && score2 == 1)
    {
        return "Snake Eyes";
    }
    
    if (score1 + score2 == 3)
    {
        return "Ace Deuce";
    }

    if (score1 == 6 && score2 == 6)
    {
        return "Box Cars";
    }
    else
    {
        return "";
    }
}


// method for random

static int GetRandom(int s)
{
    Random r = new Random();
    return r.Next(1, s + 1);
}