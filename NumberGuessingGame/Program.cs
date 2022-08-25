/*
 * Title: Number guessing game
 * Author: Steele Shreve
 * Date: 08.23.22
 */

// Variables
int usrGuess;
int aiGuess;
String playAgainChoice;
bool playAgain = true;

do // Loop until player wants to end the game
{
    Console.Write("\nWelcome to the number guessing game!\n\n");
    Console.Write($"\nGuess a number [1-6]: ");
    usrGuess = Int32.Parse(Console.ReadLine());
    aiGuess = new Random().Next(1, 7);

    if (usrGuess == aiGuess)
    {
        Console.WriteLine($"\nCongratulations, you won!\nYour guess: {usrGuess}\nAI guess: {aiGuess}");
    }
    else
    {
        Console.WriteLine($"\nNot quite!\nYour guess: {usrGuess}\nAI guess: {aiGuess}");
    }

    Console.Write("\nDo you want to play again? [Y or N]: ");

    playAgainChoice = Console.ReadLine();

    switch (playAgainChoice)
    {
        case "Y":
        case "y":
        case "Yes":
        case "yes":
            playAgain = true;
            Console.Clear();
            break;
        case "N":
        case "n":
        case "No":
        case "no":
            playAgain = false;
            break;
    }

} while (playAgain);